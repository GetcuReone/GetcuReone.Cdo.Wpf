using GetcuReone.Cdi;
using GetcuReone.Cdm.Configuration.Settings;
using GetcuReone.Cdm.Errors;
using GetcuReone.Cdo.Settings;
using GetcuReone.Cdo.Wpf.UiNotification;
using GetcuReone.Cdo.Wpf.UiNotification.Entities.Enums;
using GetcuReone.Cdo.Wpf.UiNotification.UI.NotificationWindow;
using GetcuReone.Cdo.Wpf.UiSettings;
using GetcuReone.Cdo.Wpf.UiSettings.Entities;
using GetcuReone.Cdo.Wpf.UiSettings.Models;
using GetcuReone.Cdo.Wpf.UiSettings.Pages.Context;
using GetcuReone.Cdo.Wpf.UiSettings.Pages.Namespace;
using GetcuReone.GetcuTestAdapter;
using GetcuReone.MvvmFrame.Wpf.TestAdapter;
using GetcuReone.MvvmFrame.Wpf.TestAdapter.Empty;
using GetcuReone.MvvmFrame.Wpf.TestAdapter.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace GetcuReone.Cdo.WpfTests.UiSettings
{
    [TestClass]
    public sealed class OpenSettingsAsyncTests : Env.UiTestBase
    {
        protected override void SetupViewModel<TViewModel>(TViewModel viewModel)
        {
            var subFrame = GetSubFrame();
            var mainFrame = CheckTypeAndGetPage<EmptyPage>().FindParentByType<Frame>();

            viewModel.UiServices.SetupUiSettings(mainFrame);
            viewModel.UiServices.SetupUiNitification(subFrame);
        }

        private List<SettingNamespace> GetAllNamespaces(List<SettingNamespace> namespaces)
        {
            var result = new List<SettingNamespace>();

            foreach (var nSpace in namespaces)
            {
                result.Add(nSpace);

                if (!nSpace.Namespaces.IsNullOrEmpty())
                    result.AddRange(nSpace.Namespaces);
            }

            return result;
        }

        [TestMethod]
        [TestCategory(GetcuReoneTC.Unit), TestCategory(GetcuReoneTC.Negative)]
        [Description("Open settings without notification service.")]
        [Timeout(Timeouts.Minute.One)]
        public void OpenSettingsWithoutNotificationServiceTestCase()
        {
            string expecdedMessage = $"Notification service not installed.";

            GivenShowEmptyPage()
                .And("Remove notification service.", viewModel =>
                {
                    viewModel.UiServices.Remove<IUiNotification>();
                    return viewModel.UiServices;
                })
                .When("Invoke method.",
                    uiService => ExpectedException<GetcuReoneException>(() =>
                    {
                        var task = uiService.GetUiService<IUiSettings>().OpenSettingsAsync();
                        var r = task.Result;
                    }))
                .ThenAreEqual(error => error.Message, expecdedMessage)
                .RunTestWindow(Timeouts.Minute.One);
        }

        [TestMethod]
        [TestCategory(GetcuReoneTC.Unit)]
        [Description("Open settings.")]
        [Timeout(Timeouts.Minute.One)]
        public void OpenSettingsTestCase()
        {
            GivenShowEmptyPage()
                .When("Open settings.",
                    viewModel => viewModel.UiServices.GetUiService<IUiSettings>().OpenSettingsAsync(null))
                .ThenWait(Timeouts.Millisecond.Hundred)
                .And("Check page.", _ => 
                    CheckTypeAndGetPage<ContextPage>())
                .And("Check dataContext.", page => 
                    page.CheckTypeAndDataContext<ContextViewModel>())
                .And("Check context.", viewModel =>
                {
                    var contextModel = viewModel.Context;
                    var context = GetAdapter<SettingsAdapter>().GetContext(true);

                    Assert.IsNotNull(contextModel, "Context model cannot be null.");
                    Assert.AreEqual(context.Name, contextModel.Name, "Expected another name context.");
                    Assert.AreEqual(context.Description, contextModel.Description, "Expected another description context.");
                    Assert.IsFalse(context.Namespaces.IsNullOrEmpty(), "Namespaces is empty.");

                    var namespaces = GetAllNamespaces(context.Namespaces);
                    Assert.AreEqual(namespaces.Count, contextModel.Namespaces.Count, "Expected another count namespaces.");

                    for (int i = 0; i < namespaces.Count; i++)
                    {
                        var nSpace = namespaces[i];
                        var nModel = contextModel.Namespaces[i];

                        Assert.AreEqual(nSpace.Name, nModel.Name, "Expected another name Namespace.");
                        Assert.AreEqual(nSpace.Description, nModel.Description, "Expected another description Namespace.");

                        var expectedVisibility = nSpace.Settings.IsNullOrEmpty()
                            ? Visibility.Collapsed
                            : Visibility.Visible;

                        Assert.AreEqual(expectedVisibility, nModel.Visibility, "Expected another visibility Namespace.");
                        Assert.AreEqual(nSpace.Settings.IsNullOrEmpty(), nModel.Settings.IsNullOrEmpty());

                        if (!nSpace.Settings.IsNullOrEmpty())
                        {
                            Assert.AreEqual(nSpace.Settings.Count, nModel.Settings.Count, "Expected another count settings.");

                            for (int j = 0; i < namespaces.Count; i++)
                            {
                                var setting = nSpace.Settings[j];
                                var sModel = nModel.Settings[j];

                                Assert.AreEqual(setting.Name, sModel.Name, "Expected another name setting.");
                                Assert.AreEqual(setting.Description, sModel.Description, "Expected another description setting.");
                                Assert.AreEqual(setting.Value, sModel.Value, "Expected another value setting.");
                            }
                        }
                    }
                })
                .RunTestWindow(Timeouts.Minute.One);
        }

        [TestMethod]
        [TestCategory(GetcuReoneTC.Unit)]
        [Description("Close page settings.")]
        [Timeout(Timeouts.Minute.One)]
        public void CloseSettingsTestCase()
        {
            GivenShowEmptyPage()
                .And("Open settings.",
                    viewModel => viewModel.UiServices.GetUiService<IUiSettings>().OpenSettingsAsync(null))
                .AndWait(Timeouts.Millisecond.Hundred)
                .WhenAsync("Close page.", async task =>
                {
                    var page = CheckTypeAndGetPage<ContextPage>();
                    page.FindChildByName<Button>("btnOk").OnClick();
                    await task;
                })
                .ThenWait(Timeouts.Millisecond.Hundred)
                .And("Check page.",
                    () => CheckTypeAndGetPage<EmptyPage>())
                .RunTestWindow(Timeouts.Minute.One);
        }

        [TestMethod]
        [TestCategory(GetcuReoneTC.Unit)]
        [Description("Open namespace.")]
        [Timeout(Timeouts.Minute.One)]
        public void OpenNamespaceTestCase()
        {
            string namespaceCode = "ExampleNamespaceCode";
            NamespaceModel selectedModel = null;

            GivenShowEmptyPage()
                .And("Open settings.",
                    viewModel => viewModel.UiServices.GetUiService<IUiSettings>().OpenSettingsAsync(null))
                .AndWait(Timeouts.Second.One)
                .When("Open namespace.", () =>
                {
                    var page = CheckTypeAndGetPage<ContextPage>();
                    var list = page.FindChildByName<ListBox>("listNamespaces");
                    selectedModel = page
                        .CheckTypeAndDataContext<ContextViewModel>()
                        .Context
                        .Namespaces
                        .First(n => n.Code.EqualsOrdinalIgnoreCase(namespaceCode));
                    list.SelectedItem = selectedModel;
                })
                .ThenWait(Timeouts.Second.One)
                .And("Check page.", () =>
                {
                    NamespaceModel namespaceModel = CheckTypeAndGetPage<NamespacePage>()
                        .CheckTypeAndDataContext<NamespaceViewModel>()
                        .Namespace;

                    Assert.AreEqual(selectedModel, namespaceModel, "Expected another namespaceModel");
                })
                .RunTestWindow(Timeouts.Minute.One);
        }

        [TestMethod]
        [TestCategory(GetcuReoneTC.Unit)]
        [Description("Close namespace.")]
        [Timeout(Timeouts.Minute.One)]
        public void CloseNamespaceTestCase()
        {
            string namespaceCode = "ExampleNamespaceCode";

            GivenShowEmptyPage()
                .And("Open settings.",
                    viewModel => viewModel.UiServices.GetUiService<IUiSettings>().OpenSettingsAsync(null))
                .AndWait(Timeouts.Second.One)
                .And("Open namespace.", () =>
                {
                    var page = CheckTypeAndGetPage<ContextPage>();
                    var list = page.FindChildByName<ListBox>("listNamespaces");
                    list.SelectedItem = page
                        .CheckTypeAndDataContext<ContextViewModel>()
                        .Context
                        .Namespaces
                        .First(n => n.Code.EqualsOrdinalIgnoreCase(namespaceCode));
                    return page;
                })
                .AndWait(Timeouts.Second.One)
                .When("Close page.", () => CheckTypeAndGetPage<NamespacePage>().FindChildByName<Button>("btnOk").OnClick())
                .ThenWait(Timeouts.Second.One)
                .And("Check page", () =>
                {
                    var viewModel = CheckTypeAndGetPage<ContextPage>()
                        .CheckTypeAndDataContext<ContextViewModel>();

                    Assert.IsNull(viewModel.SelectNamespace, "Must be null.");
                })
                .RunTestWindow(Timeouts.Minute.One);
        }

        [TestMethod]
        [TestCategory(GetcuReoneTC.Unit)]
        [Description("Set invalid value without SettingValueError.")]
        [Timeout(Timeouts.Minute.One)]
        public void SetInvalidValueWithoutSettingValueErrorTestCase()
        {
            string namespaceCode = "SubExampleNamespaceCode";
            string settingCode = "SettingInt";
            string invalidValue = "Hey!";
            string expectedMessage = "- Invalid setting value. Make sure you set the value correctly";
            NamespaceModel selectedModel = null;

            GivenShowEmptyPage()
                .And("Open settings.",
                    viewModel => viewModel.UiServices.GetUiService<IUiSettings>().OpenSettingsAsync(null))
                .AndWait(Timeouts.Second.One)
                .And("Open namespace.", () =>
                {
                    var page = CheckTypeAndGetPage<ContextPage>();
                    var list = page.FindChildByName<ListBox>("listNamespaces");
                    selectedModel = page
                        .CheckTypeAndDataContext<ContextViewModel>()
                        .Context
                        .Namespaces
                        .First(n => n.Code.EqualsOrdinalIgnoreCase(namespaceCode));
                    list.SelectedItem = selectedModel;
                })
                .AndWait(Timeouts.Second.One)
                .When("Set value", () =>
                {
                    var settingModel = selectedModel.Settings.First(s => s.Code.EqualsOrdinalIgnoreCase(settingCode));
                    settingModel.Value = invalidValue;
                })
                .ThenWait(Timeouts.Second.One)
                .And("Check notification", () =>
                {
                    var viewModel = CheckTypeAndGetPageSubFrame<NotificationWindowPage>().CheckTypeAndDataContext<NotificationWindowViewModel>();

                    Assert.AreEqual(NotificationTypes.Warning, viewModel.Type, "Expected another notification type.");
                    Assert.AreEqual(expectedMessage, viewModel.Message, "Expected another notification message.");
                })
                .RunTestWindow(Timeouts.Minute.One);
        }

        [TestMethod]
        [TestCategory(GetcuReoneTC.Unit)]
        [Description("Set invalid value.")]
        [Timeout(Timeouts.Minute.One)]
        public void SetInvalidValueTestCase()
        {
            string namespaceCode = "SubExampleNamespaceCode";
            string settingCode = "SettingInt";
            string invalidValue = "Hey!";
            var settingValueError = new SettingValueError
            {
                ErrorMessage = "Error Errrorroororororor",
                SettingFullCode = $"ExampleNamespaceCode.{namespaceCode}.{settingCode}"
            };
            NamespaceModel selectedModel = null;

            GivenShowEmptyPage()
                .And("Open settings.",
                    viewModel => viewModel.UiServices.GetUiService<IUiSettings>().OpenSettingsAsync(new List<SettingValueError> { settingValueError }))
                .AndWait(Timeouts.Second.Two)
                .And("Open namespace.", () =>
                {
                    var page = CheckTypeAndGetPage<ContextPage>();
                    var list = page.FindChildByName<ListBox>("listNamespaces");
                    selectedModel = page
                        .CheckTypeAndDataContext<ContextViewModel>()
                        .Context
                        .Namespaces
                        .First(n => n.Code.EqualsOrdinalIgnoreCase(namespaceCode));
                    list.SelectedItem = selectedModel;
                })
                .AndWait(Timeouts.Second.One)
                .When("Set value", () =>
                {
                    var settingModel = selectedModel.Settings.First(s => s.Code.EqualsOrdinalIgnoreCase(settingCode));
                    settingModel.Value = invalidValue;
                })
                .ThenWait(Timeouts.Second.One)
                .And("Check notification", () =>
                {
                    var viewModel = CheckTypeAndGetPageSubFrame<NotificationWindowPage>().CheckTypeAndDataContext<NotificationWindowViewModel>();

                    Assert.AreEqual(NotificationTypes.Warning, viewModel.Type, "Expected another notification type.");
                    Assert.AreEqual($"- {settingValueError.ErrorMessage}", viewModel.Message, "Expected another notification message.");
                })
                .RunTestWindow(Timeouts.Minute.One);
        }

        [TestMethod]
        [TestCategory(GetcuReoneTC.Unit)]
        [Description("Set value.")]
        [Timeout(Timeouts.Minute.One)]
        public void SetValueTestCase()
        {
            string namespaceCode = "SubExampleNamespaceCode";
            string settingCode = "SettingInt";
            string invalidValue = "1234";
            NamespaceModel selectedModel = null;
            ValueTask<List<Setting>> openSettingsTask = default;

            GivenShowEmptyPage()
                .And("Open settings.",
                    viewModel => openSettingsTask = viewModel.UiServices.GetUiService<IUiSettings>().OpenSettingsAsync(null))
                .AndWait(Timeouts.Second.One)
                .And("Open namespace.", () =>
                {
                    var page = CheckTypeAndGetPage<ContextPage>();
                    var list = page.FindChildByName<ListBox>("listNamespaces");
                    selectedModel = page
                        .CheckTypeAndDataContext<ContextViewModel>()
                        .Context
                        .Namespaces
                        .First(n => n.Code.EqualsOrdinalIgnoreCase(namespaceCode));
                    list.SelectedItem = selectedModel;
                })
                .AndWait(Timeouts.Second.One)
                .And("Set value", () =>
                {
                    var settingModel = selectedModel.Settings.First(s => s.Code.EqualsOrdinalIgnoreCase(settingCode));
                    settingModel.Value = invalidValue;
                })
                .AndWait(Timeouts.Second.One)
                .And("Close Namespace page.",
                    () => CheckTypeAndGetPage<NamespacePage>().FindChildByName<Button>("btnOk").OnClick())
                .AndWait(Timeouts.Second.One)
                .WhenAsync("Close Context page.", async () =>
                {
                    CheckTypeAndGetPage<ContextPage>().FindChildByName<Button>("btnOk").OnClick();
                    return await openSettingsTask;
                })
                .Then("Check result", settings =>
                {
                    Setting setting = settings.Single();

                    Assert.AreEqual(settingCode, setting.Code, "Expected another code.");
                    var expectedSetting = GetAdapter<SettingsAdapter>().GetSetting(setting.FullCode);
                    Assert.AreEqual(expectedSetting.Value, setting.Value, "Expected another value.");
                })
                .RunTestWindow(Timeouts.Minute.One);
        }
    }
}
