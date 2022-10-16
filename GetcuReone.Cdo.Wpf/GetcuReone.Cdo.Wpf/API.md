<a name='assembly'></a>
# GetcuReone.Cdo.Wpf

## Contents

- [AskQuestionRequest](#T-GetcuReone-Cdo-Wpf-UiQuestion-Entities-AskQuestionRequest 'GetcuReone.Cdo.Wpf.UiQuestion.Entities.AskQuestionRequest')
  - [Question](#P-GetcuReone-Cdo-Wpf-UiQuestion-Entities-AskQuestionRequest-Question 'GetcuReone.Cdo.Wpf.UiQuestion.Entities.AskQuestionRequest.Question')
  - [QuestionDetail](#P-GetcuReone-Cdo-Wpf-UiQuestion-Entities-AskQuestionRequest-QuestionDetail 'GetcuReone.Cdo.Wpf.UiQuestion.Entities.AskQuestionRequest.QuestionDetail')
- [AskQuestionResult](#T-GetcuReone-Cdo-Wpf-UiQuestion-Entities-AskQuestionResult 'GetcuReone.Cdo.Wpf.UiQuestion.Entities.AskQuestionResult')
  - [Answer](#P-GetcuReone-Cdo-Wpf-UiQuestion-Entities-AskQuestionResult-Answer 'GetcuReone.Cdo.Wpf.UiQuestion.Entities.AskQuestionResult.Answer')
- [AskQuestionViewModelBase](#T-GetcuReone-Cdo-Wpf-UiQuestion-UiBase-AskQuestionViewModelBase 'GetcuReone.Cdo.Wpf.UiQuestion.UiBase.AskQuestionViewModelBase')
  - [Answer](#P-GetcuReone-Cdo-Wpf-UiQuestion-UiBase-AskQuestionViewModelBase-Answer 'GetcuReone.Cdo.Wpf.UiQuestion.UiBase.AskQuestionViewModelBase.Answer')
  - [Question](#P-GetcuReone-Cdo-Wpf-UiQuestion-UiBase-AskQuestionViewModelBase-Question 'GetcuReone.Cdo.Wpf.UiQuestion.UiBase.AskQuestionViewModelBase.Question')
  - [QuestionDetail](#P-GetcuReone-Cdo-Wpf-UiQuestion-UiBase-AskQuestionViewModelBase-QuestionDetail 'GetcuReone.Cdo.Wpf.UiQuestion.UiBase.AskQuestionViewModelBase.QuestionDetail')
  - [VisibilityPage](#P-GetcuReone-Cdo-Wpf-UiQuestion-UiBase-AskQuestionViewModelBase-VisibilityPage 'GetcuReone.Cdo.Wpf.UiQuestion.UiBase.AskQuestionViewModelBase.VisibilityPage')
  - [CloseQuestion()](#M-GetcuReone-Cdo-Wpf-UiQuestion-UiBase-AskQuestionViewModelBase-CloseQuestion 'GetcuReone.Cdo.Wpf.UiQuestion.UiBase.AskQuestionViewModelBase.CloseQuestion')
  - [Initialize()](#M-GetcuReone-Cdo-Wpf-UiQuestion-UiBase-AskQuestionViewModelBase-Initialize 'GetcuReone.Cdo.Wpf.UiQuestion.UiBase.AskQuestionViewModelBase.Initialize')
  - [OnGoPageAsync()](#M-GetcuReone-Cdo-Wpf-UiQuestion-UiBase-AskQuestionViewModelBase-OnGoPageAsync-System-Object- 'GetcuReone.Cdo.Wpf.UiQuestion.UiBase.AskQuestionViewModelBase.OnGoPageAsync(System.Object)')
  - [OnLeavePageAsync()](#M-GetcuReone-Cdo-Wpf-UiQuestion-UiBase-AskQuestionViewModelBase-OnLeavePageAsync-GetcuReone-MvvmFrame-Wpf-EventArgs-NavigatingEventArgs- 'GetcuReone.Cdo.Wpf.UiQuestion.UiBase.AskQuestionViewModelBase.OnLeavePageAsync(GetcuReone.MvvmFrame.Wpf.EventArgs.NavigatingEventArgs)')
  - [OnLoadPageAsync()](#M-GetcuReone-Cdo-Wpf-UiQuestion-UiBase-AskQuestionViewModelBase-OnLoadPageAsync 'GetcuReone.Cdo.Wpf.UiQuestion.UiBase.AskQuestionViewModelBase.OnLoadPageAsync')
- [AskQuestionYesNoPage](#T-GetcuReone-Cdo-Wpf-UiQuestion-AskQuestionYesNo-AskQuestionYesNoPage 'GetcuReone.Cdo.Wpf.UiQuestion.AskQuestionYesNo.AskQuestionYesNoPage')
  - [InitializeComponent()](#M-GetcuReone-Cdo-Wpf-UiQuestion-AskQuestionYesNo-AskQuestionYesNoPage-InitializeComponent 'GetcuReone.Cdo.Wpf.UiQuestion.AskQuestionYesNo.AskQuestionYesNoPage.InitializeComponent')
  - [InitializePageComponent\`\`1(viewModel)](#M-GetcuReone-Cdo-Wpf-UiQuestion-AskQuestionYesNo-AskQuestionYesNoPage-InitializePageComponent``1-``0- 'GetcuReone.Cdo.Wpf.UiQuestion.AskQuestionYesNo.AskQuestionYesNoPage.InitializePageComponent``1(``0)')
- [AskQuestionYesNoViewModel](#T-GetcuReone-Cdo-Wpf-UiQuestion-AskQuestionYesNo-AskQuestionYesNoViewModel 'GetcuReone.Cdo.Wpf.UiQuestion.AskQuestionYesNo.AskQuestionYesNoViewModel')
  - [No_ButtonModel](#P-GetcuReone-Cdo-Wpf-UiQuestion-AskQuestionYesNo-AskQuestionYesNoViewModel-No_ButtonModel 'GetcuReone.Cdo.Wpf.UiQuestion.AskQuestionYesNo.AskQuestionYesNoViewModel.No_ButtonModel')
  - [Yes_ButtonModel](#P-GetcuReone-Cdo-Wpf-UiQuestion-AskQuestionYesNo-AskQuestionYesNoViewModel-Yes_ButtonModel 'GetcuReone.Cdo.Wpf.UiQuestion.AskQuestionYesNo.AskQuestionYesNoViewModel.Yes_ButtonModel')
  - [Initialize()](#M-GetcuReone-Cdo-Wpf-UiQuestion-AskQuestionYesNo-AskQuestionYesNoViewModel-Initialize 'GetcuReone.Cdo.Wpf.UiQuestion.AskQuestionYesNo.AskQuestionYesNoViewModel.Initialize')
- [CdoWpfErrorCode](#T-GetcuReone-Cdo-Wpf-CdoWpfErrorCode 'GetcuReone.Cdo.Wpf.CdoWpfErrorCode')
  - [InvalidSettingValue](#F-GetcuReone-Cdo-Wpf-CdoWpfErrorCode-InvalidSettingValue 'GetcuReone.Cdo.Wpf.CdoWpfErrorCode.InvalidSettingValue')
  - [NotificationNotInstalled](#F-GetcuReone-Cdo-Wpf-CdoWpfErrorCode-NotificationNotInstalled 'GetcuReone.Cdo.Wpf.CdoWpfErrorCode.NotificationNotInstalled')
- [CdoWpfRulesProvider](#T-GetcuReone-Cdo-Wpf-FactFactory-CdoWpfRulesProvider 'GetcuReone.Cdo.Wpf.FactFactory.CdoWpfRulesProvider')
  - [GetDefaultFacts()](#M-GetcuReone-Cdo-Wpf-FactFactory-CdoWpfRulesProvider-GetDefaultFacts 'GetcuReone.Cdo.Wpf.FactFactory.CdoWpfRulesProvider.GetDefaultFacts')
  - [GetRules()](#M-GetcuReone-Cdo-Wpf-FactFactory-CdoWpfRulesProvider-GetRules 'GetcuReone.Cdo.Wpf.FactFactory.CdoWpfRulesProvider.GetRules')
- [ContextModel](#T-GetcuReone-Cdo-Wpf-UiSettings-Models-ContextModel 'GetcuReone.Cdo.Wpf.UiSettings.Models.ContextModel')
  - [Description](#P-GetcuReone-Cdo-Wpf-UiSettings-Models-ContextModel-Description 'GetcuReone.Cdo.Wpf.UiSettings.Models.ContextModel.Description')
  - [Name](#P-GetcuReone-Cdo-Wpf-UiSettings-Models-ContextModel-Name 'GetcuReone.Cdo.Wpf.UiSettings.Models.ContextModel.Name')
  - [Namespaces](#P-GetcuReone-Cdo-Wpf-UiSettings-Models-ContextModel-Namespaces 'GetcuReone.Cdo.Wpf.UiSettings.Models.ContextModel.Namespaces')
- [ContextPage](#T-GetcuReone-Cdo-Wpf-UiSettings-Pages-Context-ContextPage 'GetcuReone.Cdo.Wpf.UiSettings.Pages.Context.ContextPage')
  - [InitializeComponent()](#M-GetcuReone-Cdo-Wpf-UiSettings-Pages-Context-ContextPage-InitializeComponent 'GetcuReone.Cdo.Wpf.UiSettings.Pages.Context.ContextPage.InitializeComponent')
  - [InitializePageComponent\`\`1(viewModel)](#M-GetcuReone-Cdo-Wpf-UiSettings-Pages-Context-ContextPage-InitializePageComponent``1-``0- 'GetcuReone.Cdo.Wpf.UiSettings.Pages.Context.ContextPage.InitializePageComponent``1(``0)')
- [ContextViewModel](#T-GetcuReone-Cdo-Wpf-UiSettings-Pages-Context-ContextViewModel 'GetcuReone.Cdo.Wpf.UiSettings.Pages.Context.ContextViewModel')
  - [Context](#P-GetcuReone-Cdo-Wpf-UiSettings-Pages-Context-ContextViewModel-Context 'GetcuReone.Cdo.Wpf.UiSettings.Pages.Context.ContextViewModel.Context')
  - [Ok_Command](#P-GetcuReone-Cdo-Wpf-UiSettings-Pages-Context-ContextViewModel-Ok_Command 'GetcuReone.Cdo.Wpf.UiSettings.Pages.Context.ContextViewModel.Ok_Command')
  - [SelectNamespace](#P-GetcuReone-Cdo-Wpf-UiSettings-Pages-Context-ContextViewModel-SelectNamespace 'GetcuReone.Cdo.Wpf.UiSettings.Pages.Context.ContextViewModel.SelectNamespace')
  - [Initialize()](#M-GetcuReone-Cdo-Wpf-UiSettings-Pages-Context-ContextViewModel-Initialize 'GetcuReone.Cdo.Wpf.UiSettings.Pages.Context.ContextViewModel.Initialize')
  - [OnGoPageAsync()](#M-GetcuReone-Cdo-Wpf-UiSettings-Pages-Context-ContextViewModel-OnGoPageAsync-System-Object- 'GetcuReone.Cdo.Wpf.UiSettings.Pages.Context.ContextViewModel.OnGoPageAsync(System.Object)')
- [FileDialogService](#T-GetcuReone-Cdo-Wpf-OpenFileDialog-FileDialogService 'GetcuReone.Cdo.Wpf.OpenFileDialog.FileDialogService')
  - [FactoryName](#P-GetcuReone-Cdo-Wpf-OpenFileDialog-FileDialogService-FactoryName 'GetcuReone.Cdo.Wpf.OpenFileDialog.FileDialogService.FactoryName')
  - [SelectFiles()](#M-GetcuReone-Cdo-Wpf-OpenFileDialog-FileDialogService-SelectFiles-GetcuReone-Cdo-Wpf-OpenFileDialog-Entities-SelectFilesRequest- 'GetcuReone.Cdo.Wpf.OpenFileDialog.FileDialogService.SelectFiles(GetcuReone.Cdo.Wpf.OpenFileDialog.Entities.SelectFilesRequest)')
- [FileExplorerAdapter](#T-GetcuReone-Cdo-Wpf-FileExplorer-FileExplorerAdapter 'GetcuReone.Cdo.Wpf.FileExplorer.FileExplorerAdapter')
  - [AdapterName](#P-GetcuReone-Cdo-Wpf-FileExplorer-FileExplorerAdapter-AdapterName 'GetcuReone.Cdo.Wpf.FileExplorer.FileExplorerAdapter.AdapterName')
  - [SelectItem(pathItem)](#M-GetcuReone-Cdo-Wpf-FileExplorer-FileExplorerAdapter-SelectItem-System-String- 'GetcuReone.Cdo.Wpf.FileExplorer.FileExplorerAdapter.SelectItem(System.String)')
- [IFileDialog](#T-GetcuReone-Cdo-Wpf-OpenFileDialog-IFileDialog 'GetcuReone.Cdo.Wpf.OpenFileDialog.IFileDialog')
  - [SelectFiles(request)](#M-GetcuReone-Cdo-Wpf-OpenFileDialog-IFileDialog-SelectFiles-GetcuReone-Cdo-Wpf-OpenFileDialog-Entities-SelectFilesRequest- 'GetcuReone.Cdo.Wpf.OpenFileDialog.IFileDialog.SelectFiles(GetcuReone.Cdo.Wpf.OpenFileDialog.Entities.SelectFilesRequest)')
- [IUiNotification](#T-GetcuReone-Cdo-Wpf-UiNotification-IUiNotification 'GetcuReone.Cdo.Wpf.UiNotification.IUiNotification')
  - [SendNotificationWindow(request)](#M-GetcuReone-Cdo-Wpf-UiNotification-IUiNotification-SendNotificationWindow-GetcuReone-Cdo-Wpf-UiNotification-Entities-UiNotificationRequest- 'GetcuReone.Cdo.Wpf.UiNotification.IUiNotification.SendNotificationWindow(GetcuReone.Cdo.Wpf.UiNotification.Entities.UiNotificationRequest)')
- [IUiQuestion](#T-GetcuReone-Cdo-Wpf-UiQuestion-IUiQuestion 'GetcuReone.Cdo.Wpf.UiQuestion.IUiQuestion')
  - [AskQuestionYesNoAsync(request)](#M-GetcuReone-Cdo-Wpf-UiQuestion-IUiQuestion-AskQuestionYesNoAsync-GetcuReone-Cdo-Wpf-UiQuestion-Entities-AskQuestionRequest- 'GetcuReone.Cdo.Wpf.UiQuestion.IUiQuestion.AskQuestionYesNoAsync(GetcuReone.Cdo.Wpf.UiQuestion.Entities.AskQuestionRequest)')
- [IUiSettings](#T-GetcuReone-Cdo-Wpf-UiSettings-IUiSettings 'GetcuReone.Cdo.Wpf.UiSettings.IUiSettings')
  - [OpenSettingsAsync(settingValueErrors)](#M-GetcuReone-Cdo-Wpf-UiSettings-IUiSettings-OpenSettingsAsync-System-Collections-Generic-List{GetcuReone-Cdo-Wpf-UiSettings-Entities-SettingValueError}- 'GetcuReone.Cdo.Wpf.UiSettings.IUiSettings.OpenSettingsAsync(System.Collections.Generic.List{GetcuReone.Cdo.Wpf.UiSettings.Entities.SettingValueError})')
- [NamespaceModel](#T-GetcuReone-Cdo-Wpf-UiSettings-Models-NamespaceModel 'GetcuReone.Cdo.Wpf.UiSettings.Models.NamespaceModel')
  - [Code](#P-GetcuReone-Cdo-Wpf-UiSettings-Models-NamespaceModel-Code 'GetcuReone.Cdo.Wpf.UiSettings.Models.NamespaceModel.Code')
  - [Description](#P-GetcuReone-Cdo-Wpf-UiSettings-Models-NamespaceModel-Description 'GetcuReone.Cdo.Wpf.UiSettings.Models.NamespaceModel.Description')
  - [Name](#P-GetcuReone-Cdo-Wpf-UiSettings-Models-NamespaceModel-Name 'GetcuReone.Cdo.Wpf.UiSettings.Models.NamespaceModel.Name')
  - [NamespacePath](#P-GetcuReone-Cdo-Wpf-UiSettings-Models-NamespaceModel-NamespacePath 'GetcuReone.Cdo.Wpf.UiSettings.Models.NamespaceModel.NamespacePath')
  - [Settings](#P-GetcuReone-Cdo-Wpf-UiSettings-Models-NamespaceModel-Settings 'GetcuReone.Cdo.Wpf.UiSettings.Models.NamespaceModel.Settings')
  - [Visibility](#P-GetcuReone-Cdo-Wpf-UiSettings-Models-NamespaceModel-Visibility 'GetcuReone.Cdo.Wpf.UiSettings.Models.NamespaceModel.Visibility')
- [NamespacePage](#T-GetcuReone-Cdo-Wpf-UiSettings-Pages-Namespace-NamespacePage 'GetcuReone.Cdo.Wpf.UiSettings.Pages.Namespace.NamespacePage')
  - [InitializeComponent()](#M-GetcuReone-Cdo-Wpf-UiSettings-Pages-Namespace-NamespacePage-InitializeComponent 'GetcuReone.Cdo.Wpf.UiSettings.Pages.Namespace.NamespacePage.InitializeComponent')
  - [InitializePageComponent\`\`1(viewModel)](#M-GetcuReone-Cdo-Wpf-UiSettings-Pages-Namespace-NamespacePage-InitializePageComponent``1-``0- 'GetcuReone.Cdo.Wpf.UiSettings.Pages.Namespace.NamespacePage.InitializePageComponent``1(``0)')
- [NamespaceViewModel](#T-GetcuReone-Cdo-Wpf-UiSettings-Pages-Namespace-NamespaceViewModel 'GetcuReone.Cdo.Wpf.UiSettings.Pages.Namespace.NamespaceViewModel')
  - [Namespace](#P-GetcuReone-Cdo-Wpf-UiSettings-Pages-Namespace-NamespaceViewModel-Namespace 'GetcuReone.Cdo.Wpf.UiSettings.Pages.Namespace.NamespaceViewModel.Namespace')
  - [Ok_Command](#P-GetcuReone-Cdo-Wpf-UiSettings-Pages-Namespace-NamespaceViewModel-Ok_Command 'GetcuReone.Cdo.Wpf.UiSettings.Pages.Namespace.NamespaceViewModel.Ok_Command')
  - [Initialize()](#M-GetcuReone-Cdo-Wpf-UiSettings-Pages-Namespace-NamespaceViewModel-Initialize 'GetcuReone.Cdo.Wpf.UiSettings.Pages.Namespace.NamespaceViewModel.Initialize')
  - [OnGoPageAsync()](#M-GetcuReone-Cdo-Wpf-UiSettings-Pages-Namespace-NamespaceViewModel-OnGoPageAsync-System-Object- 'GetcuReone.Cdo.Wpf.UiSettings.Pages.Namespace.NamespaceViewModel.OnGoPageAsync(System.Object)')
- [NotificationTypes](#T-GetcuReone-Cdo-Wpf-UiNotification-Entities-Enums-NotificationTypes 'GetcuReone.Cdo.Wpf.UiNotification.Entities.Enums.NotificationTypes')
  - [Error](#F-GetcuReone-Cdo-Wpf-UiNotification-Entities-Enums-NotificationTypes-Error 'GetcuReone.Cdo.Wpf.UiNotification.Entities.Enums.NotificationTypes.Error')
  - [Info](#F-GetcuReone-Cdo-Wpf-UiNotification-Entities-Enums-NotificationTypes-Info 'GetcuReone.Cdo.Wpf.UiNotification.Entities.Enums.NotificationTypes.Info')
  - [Warning](#F-GetcuReone-Cdo-Wpf-UiNotification-Entities-Enums-NotificationTypes-Warning 'GetcuReone.Cdo.Wpf.UiNotification.Entities.Enums.NotificationTypes.Warning')
- [NotificationVeiwModelBase](#T-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationVeiwModelBase 'GetcuReone.Cdo.Wpf.UiNotification.UI.NotificationVeiwModelBase')
  - [CloseNotification_ButtonModel](#P-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationVeiwModelBase-CloseNotification_ButtonModel 'GetcuReone.Cdo.Wpf.UiNotification.UI.NotificationVeiwModelBase.CloseNotification_ButtonModel')
  - [Message](#P-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationVeiwModelBase-Message 'GetcuReone.Cdo.Wpf.UiNotification.UI.NotificationVeiwModelBase.Message')
  - [Request](#P-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationVeiwModelBase-Request 'GetcuReone.Cdo.Wpf.UiNotification.UI.NotificationVeiwModelBase.Request')
  - [Title](#P-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationVeiwModelBase-Title 'GetcuReone.Cdo.Wpf.UiNotification.UI.NotificationVeiwModelBase.Title')
  - [Type](#P-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationVeiwModelBase-Type 'GetcuReone.Cdo.Wpf.UiNotification.UI.NotificationVeiwModelBase.Type')
  - [Visibility](#P-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationVeiwModelBase-Visibility 'GetcuReone.Cdo.Wpf.UiNotification.UI.NotificationVeiwModelBase.Visibility')
  - [GoBack()](#M-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationVeiwModelBase-GoBack 'GetcuReone.Cdo.Wpf.UiNotification.UI.NotificationVeiwModelBase.GoBack')
  - [Initialize()](#M-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationVeiwModelBase-Initialize 'GetcuReone.Cdo.Wpf.UiNotification.UI.NotificationVeiwModelBase.Initialize')
  - [OnGoPageAsync()](#M-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationVeiwModelBase-OnGoPageAsync-System-Object- 'GetcuReone.Cdo.Wpf.UiNotification.UI.NotificationVeiwModelBase.OnGoPageAsync(System.Object)')
  - [OnLeavePageAsync()](#M-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationVeiwModelBase-OnLeavePageAsync-GetcuReone-MvvmFrame-Wpf-EventArgs-NavigatingEventArgs- 'GetcuReone.Cdo.Wpf.UiNotification.UI.NotificationVeiwModelBase.OnLeavePageAsync(GetcuReone.MvvmFrame.Wpf.EventArgs.NavigatingEventArgs)')
  - [OnLoadPageAsync()](#M-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationVeiwModelBase-OnLoadPageAsync 'GetcuReone.Cdo.Wpf.UiNotification.UI.NotificationVeiwModelBase.OnLoadPageAsync')
- [NotificationWindowPage](#T-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationWindow-NotificationWindowPage 'GetcuReone.Cdo.Wpf.UiNotification.UI.NotificationWindow.NotificationWindowPage')
  - [InitializeComponent()](#M-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationWindow-NotificationWindowPage-InitializeComponent 'GetcuReone.Cdo.Wpf.UiNotification.UI.NotificationWindow.NotificationWindowPage.InitializeComponent')
  - [InitializePageComponent\`\`1(viewModel)](#M-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationWindow-NotificationWindowPage-InitializePageComponent``1-``0- 'GetcuReone.Cdo.Wpf.UiNotification.UI.NotificationWindow.NotificationWindowPage.InitializePageComponent``1(``0)')
- [NotificationWindowViewModel](#T-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationWindow-NotificationWindowViewModel 'GetcuReone.Cdo.Wpf.UiNotification.UI.NotificationWindow.NotificationWindowViewModel')
- [OpenFileDialogAdapter](#T-GetcuReone-Cdo-Wpf-OpenFileDialog-OpenFileDialogAdapter 'GetcuReone.Cdo.Wpf.OpenFileDialog.OpenFileDialogAdapter')
  - [#ctor()](#M-GetcuReone-Cdo-Wpf-OpenFileDialog-OpenFileDialogAdapter-#ctor 'GetcuReone.Cdo.Wpf.OpenFileDialog.OpenFileDialogAdapter.#ctor')
  - [AdapterName](#P-GetcuReone-Cdo-Wpf-OpenFileDialog-OpenFileDialogAdapter-AdapterName 'GetcuReone.Cdo.Wpf.OpenFileDialog.OpenFileDialogAdapter.AdapterName')
  - [SelectFiles(request)](#M-GetcuReone-Cdo-Wpf-OpenFileDialog-OpenFileDialogAdapter-SelectFiles-GetcuReone-Cdo-Wpf-OpenFileDialog-Entities-SelectFilesRequest- 'GetcuReone.Cdo.Wpf.OpenFileDialog.OpenFileDialogAdapter.SelectFiles(GetcuReone.Cdo.Wpf.OpenFileDialog.Entities.SelectFilesRequest)')
- [OpenSettings_ContextModel](#T-GetcuReone-Cdo-Wpf-FactFactory-Facts-UiSettings-OpenSettings_ContextModel 'GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings.OpenSettings_ContextModel')
- [OpenSettings_NamespaceModels](#T-GetcuReone-Cdo-Wpf-FactFactory-Facts-UiSettings-OpenSettings_NamespaceModels 'GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings.OpenSettings_NamespaceModels')
- [OpenSettings_SettingModel](#T-GetcuReone-Cdo-Wpf-FactFactory-Facts-UiSettings-OpenSettings_SettingModel 'GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings.OpenSettings_SettingModel')
- [OpenSettings_SettingModel_Setting](#T-GetcuReone-Cdo-Wpf-FactFactory-Facts-UiSettings-OpenSettings_SettingModel_Setting 'GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings.OpenSettings_SettingModel_Setting')
- [OpenSettings_SettingModel_ValidationErrors](#T-GetcuReone-Cdo-Wpf-FactFactory-Facts-UiSettings-OpenSettings_SettingModel_ValidationErrors 'GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings.OpenSettings_SettingModel_ValidationErrors')
- [OpenSettings_SettingModels](#T-GetcuReone-Cdo-Wpf-FactFactory-Facts-UiSettings-OpenSettings_SettingModels 'GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings.OpenSettings_SettingModels')
- [OpenSettings_SettingTypes](#T-GetcuReone-Cdo-Wpf-FactFactory-Facts-UiSettings-OpenSettings_SettingTypes 'GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings.OpenSettings_SettingTypes')
- [OpenSettings_SettingValueError](#T-GetcuReone-Cdo-Wpf-FactFactory-Facts-UiSettings-OpenSettings_SettingValueError 'GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings.OpenSettings_SettingValueError')
- [OpenSettings_SettingValueErrors](#T-GetcuReone-Cdo-Wpf-FactFactory-Facts-UiSettings-OpenSettings_SettingValueErrors 'GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings.OpenSettings_SettingValueErrors')
- [OpenSettings_Settings_Changed](#T-GetcuReone-Cdo-Wpf-FactFactory-Facts-UiSettings-OpenSettings_Settings_Changed 'GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings.OpenSettings_Settings_Changed')
- [OpenSettings_ViewModel](#T-GetcuReone-Cdo-Wpf-FactFactory-Facts-UiSettings-OpenSettings_ViewModel 'GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings.OpenSettings_ViewModel')
- [RadioButtonModel](#T-GetcuReone-Cdo-Wpf-Models-RadioButtonModel 'GetcuReone.Cdo.Wpf.Models.RadioButtonModel')
- [RadioButtonModel\`1](#T-GetcuReone-Cdo-Wpf-Models-RadioButtonModel`1 'GetcuReone.Cdo.Wpf.Models.RadioButtonModel`1')
  - [GroupName](#P-GetcuReone-Cdo-Wpf-Models-RadioButtonModel`1-GroupName 'GetcuReone.Cdo.Wpf.Models.RadioButtonModel`1.GroupName')
  - [IsChecked](#P-GetcuReone-Cdo-Wpf-Models-RadioButtonModel`1-IsChecked 'GetcuReone.Cdo.Wpf.Models.RadioButtonModel`1.IsChecked')
  - [Value](#P-GetcuReone-Cdo-Wpf-Models-RadioButtonModel`1-Value 'GetcuReone.Cdo.Wpf.Models.RadioButtonModel`1.Value')
- [SelectFilesRequest](#T-GetcuReone-Cdo-Wpf-OpenFileDialog-Entities-SelectFilesRequest 'GetcuReone.Cdo.Wpf.OpenFileDialog.Entities.SelectFilesRequest')
  - [CheckFileExists](#P-GetcuReone-Cdo-Wpf-OpenFileDialog-Entities-SelectFilesRequest-CheckFileExists 'GetcuReone.Cdo.Wpf.OpenFileDialog.Entities.SelectFilesRequest.CheckFileExists')
  - [Filter](#P-GetcuReone-Cdo-Wpf-OpenFileDialog-Entities-SelectFilesRequest-Filter 'GetcuReone.Cdo.Wpf.OpenFileDialog.Entities.SelectFilesRequest.Filter')
  - [InitialFolder](#P-GetcuReone-Cdo-Wpf-OpenFileDialog-Entities-SelectFilesRequest-InitialFolder 'GetcuReone.Cdo.Wpf.OpenFileDialog.Entities.SelectFilesRequest.InitialFolder')
  - [MultiSelect](#P-GetcuReone-Cdo-Wpf-OpenFileDialog-Entities-SelectFilesRequest-MultiSelect 'GetcuReone.Cdo.Wpf.OpenFileDialog.Entities.SelectFilesRequest.MultiSelect')
  - [TitleDialog](#P-GetcuReone-Cdo-Wpf-OpenFileDialog-Entities-SelectFilesRequest-TitleDialog 'GetcuReone.Cdo.Wpf.OpenFileDialog.Entities.SelectFilesRequest.TitleDialog')
- [SelectFilesResult](#T-GetcuReone-Cdo-Wpf-OpenFileDialog-Entities-SelectFilesResult 'GetcuReone.Cdo.Wpf.OpenFileDialog.Entities.SelectFilesResult')
  - [ResultShowDialog](#P-GetcuReone-Cdo-Wpf-OpenFileDialog-Entities-SelectFilesResult-ResultShowDialog 'GetcuReone.Cdo.Wpf.OpenFileDialog.Entities.SelectFilesResult.ResultShowDialog')
  - [SelectedFiles](#P-GetcuReone-Cdo-Wpf-OpenFileDialog-Entities-SelectFilesResult-SelectedFiles 'GetcuReone.Cdo.Wpf.OpenFileDialog.Entities.SelectFilesResult.SelectedFiles')
- [SettingModel](#T-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel 'GetcuReone.Cdo.Wpf.UiSettings.Models.SettingModel')
  - [Code](#P-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel-Code 'GetcuReone.Cdo.Wpf.UiSettings.Models.SettingModel.Code')
  - [Description](#P-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel-Description 'GetcuReone.Cdo.Wpf.UiSettings.Models.SettingModel.Description')
  - [Name](#P-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel-Name 'GetcuReone.Cdo.Wpf.UiSettings.Models.SettingModel.Name')
  - [PermissibleValues](#P-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel-PermissibleValues 'GetcuReone.Cdo.Wpf.UiSettings.Models.SettingModel.PermissibleValues')
  - [PermissibleValuesIsEnabled](#P-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel-PermissibleValuesIsEnabled 'GetcuReone.Cdo.Wpf.UiSettings.Models.SettingModel.PermissibleValuesIsEnabled')
  - [PermissibleValuesVisibility](#P-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel-PermissibleValuesVisibility 'GetcuReone.Cdo.Wpf.UiSettings.Models.SettingModel.PermissibleValuesVisibility')
  - [TextBoxVisibility](#P-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel-TextBoxVisibility 'GetcuReone.Cdo.Wpf.UiSettings.Models.SettingModel.TextBoxVisibility')
  - [Value](#P-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel-Value 'GetcuReone.Cdo.Wpf.UiSettings.Models.SettingModel.Value')
  - [Initialize()](#M-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel-Initialize 'GetcuReone.Cdo.Wpf.UiSettings.Models.SettingModel.Initialize')
  - [OnErrors()](#M-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel-OnErrors-System-Collections-ObjectModel-ReadOnlyCollection{GetcuReone-MvvmFrame-Entities-MvvmFrameErrorDetail}- 'GetcuReone.Cdo.Wpf.UiSettings.Models.SettingModel.OnErrors(System.Collections.ObjectModel.ReadOnlyCollection{GetcuReone.MvvmFrame.Entities.MvvmFrameErrorDetail})')
  - [OnVerification()](#M-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel-OnVerification-GetcuReone-MvvmFrame-EventArgs-MvvmElementPropertyVerifyChangeEventArgs- 'GetcuReone.Cdo.Wpf.UiSettings.Models.SettingModel.OnVerification(GetcuReone.MvvmFrame.EventArgs.MvvmElementPropertyVerifyChangeEventArgs)')
- [SettingValueError](#T-GetcuReone-Cdo-Wpf-UiSettings-Entities-SettingValueError 'GetcuReone.Cdo.Wpf.UiSettings.Entities.SettingValueError')
  - [ErrorMessage](#P-GetcuReone-Cdo-Wpf-UiSettings-Entities-SettingValueError-ErrorMessage 'GetcuReone.Cdo.Wpf.UiSettings.Entities.SettingValueError.ErrorMessage')
  - [SettingFullCode](#P-GetcuReone-Cdo-Wpf-UiSettings-Entities-SettingValueError-SettingFullCode 'GetcuReone.Cdo.Wpf.UiSettings.Entities.SettingValueError.SettingFullCode')
- [TextModel](#T-GetcuReone-Cdo-Wpf-Models-TextModel 'GetcuReone.Cdo.Wpf.Models.TextModel')
  - [Text](#P-GetcuReone-Cdo-Wpf-Models-TextModel-Text 'GetcuReone.Cdo.Wpf.Models.TextModel.Text')
  - [Visibility](#P-GetcuReone-Cdo-Wpf-Models-TextModel-Visibility 'GetcuReone.Cdo.Wpf.Models.TextModel.Visibility')
- [UiNotificationRequest](#T-GetcuReone-Cdo-Wpf-UiNotification-Entities-UiNotificationRequest 'GetcuReone.Cdo.Wpf.UiNotification.Entities.UiNotificationRequest')
  - [Message](#P-GetcuReone-Cdo-Wpf-UiNotification-Entities-UiNotificationRequest-Message 'GetcuReone.Cdo.Wpf.UiNotification.Entities.UiNotificationRequest.Message')
  - [Title](#P-GetcuReone-Cdo-Wpf-UiNotification-Entities-UiNotificationRequest-Title 'GetcuReone.Cdo.Wpf.UiNotification.Entities.UiNotificationRequest.Title')
  - [Type](#P-GetcuReone-Cdo-Wpf-UiNotification-Entities-UiNotificationRequest-Type 'GetcuReone.Cdo.Wpf.UiNotification.Entities.UiNotificationRequest.Type')
- [UiNotificationSetupHelper](#T-GetcuReone-Cdo-Wpf-UiNotification-UiNotificationSetupHelper 'GetcuReone.Cdo.Wpf.UiNotification.UiNotificationSetupHelper')
  - [SetupUiNitification\`\`1(configUi,frame)](#M-GetcuReone-Cdo-Wpf-UiNotification-UiNotificationSetupHelper-SetupUiNitification``1-``0,System-Windows-Controls-Frame- 'GetcuReone.Cdo.Wpf.UiNotification.UiNotificationSetupHelper.SetupUiNitification``1(``0,System.Windows.Controls.Frame)')
- [UiQuestionSetupHelper](#T-GetcuReone-Cdo-Wpf-UiQuestion-UiQuestionSetupHelper 'GetcuReone.Cdo.Wpf.UiQuestion.UiQuestionSetupHelper')
  - [SetupUiQuestion\`\`1(configUi,frame)](#M-GetcuReone-Cdo-Wpf-UiQuestion-UiQuestionSetupHelper-SetupUiQuestion``1-``0,System-Windows-Controls-Frame- 'GetcuReone.Cdo.Wpf.UiQuestion.UiQuestionSetupHelper.SetupUiQuestion``1(``0,System.Windows.Controls.Frame)')
- [UiSettingsSetupHelper](#T-GetcuReone-Cdo-Wpf-UiSettings-UiSettingsSetupHelper 'GetcuReone.Cdo.Wpf.UiSettings.UiSettingsSetupHelper')
  - [SetupUiSettings\`\`1(configUi,frame)](#M-GetcuReone-Cdo-Wpf-UiSettings-UiSettingsSetupHelper-SetupUiSettings``1-``0,System-Windows-Controls-Frame- 'GetcuReone.Cdo.Wpf.UiSettings.UiSettingsSetupHelper.SetupUiSettings``1(``0,System.Windows.Controls.Frame)')

<a name='T-GetcuReone-Cdo-Wpf-UiQuestion-Entities-AskQuestionRequest'></a>
## AskQuestionRequest `type`

##### Namespace

GetcuReone.Cdo.Wpf.UiQuestion.Entities

##### Summary

Request to ask a question.

<a name='P-GetcuReone-Cdo-Wpf-UiQuestion-Entities-AskQuestionRequest-Question'></a>
### Question `property`

##### Summary

Text question.

<a name='P-GetcuReone-Cdo-Wpf-UiQuestion-Entities-AskQuestionRequest-QuestionDetail'></a>
### QuestionDetail `property`

##### Summary

Additional information to the question.

<a name='T-GetcuReone-Cdo-Wpf-UiQuestion-Entities-AskQuestionResult'></a>
## AskQuestionResult `type`

##### Namespace

GetcuReone.Cdo.Wpf.UiQuestion.Entities

##### Summary

Result to ask a question.

<a name='P-GetcuReone-Cdo-Wpf-UiQuestion-Entities-AskQuestionResult-Answer'></a>
### Answer `property`

##### Summary

Answer.

<a name='T-GetcuReone-Cdo-Wpf-UiQuestion-UiBase-AskQuestionViewModelBase'></a>
## AskQuestionViewModelBase `type`

##### Namespace

GetcuReone.Cdo.Wpf.UiQuestion.UiBase

##### Summary

Base view-model.

<a name='P-GetcuReone-Cdo-Wpf-UiQuestion-UiBase-AskQuestionViewModelBase-Answer'></a>
### Answer `property`

##### Summary

Answer.

<a name='P-GetcuReone-Cdo-Wpf-UiQuestion-UiBase-AskQuestionViewModelBase-Question'></a>
### Question `property`

##### Summary

Text question.

<a name='P-GetcuReone-Cdo-Wpf-UiQuestion-UiBase-AskQuestionViewModelBase-QuestionDetail'></a>
### QuestionDetail `property`

##### Summary

Question detail.

<a name='P-GetcuReone-Cdo-Wpf-UiQuestion-UiBase-AskQuestionViewModelBase-VisibilityPage'></a>
### VisibilityPage `property`

##### Summary

Page visibility.

<a name='M-GetcuReone-Cdo-Wpf-UiQuestion-UiBase-AskQuestionViewModelBase-CloseQuestion'></a>
### CloseQuestion() `method`

##### Summary

Close question.

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Wpf-UiQuestion-UiBase-AskQuestionViewModelBase-Initialize'></a>
### Initialize() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Wpf-UiQuestion-UiBase-AskQuestionViewModelBase-OnGoPageAsync-System-Object-'></a>
### OnGoPageAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Wpf-UiQuestion-UiBase-AskQuestionViewModelBase-OnLeavePageAsync-GetcuReone-MvvmFrame-Wpf-EventArgs-NavigatingEventArgs-'></a>
### OnLeavePageAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Wpf-UiQuestion-UiBase-AskQuestionViewModelBase-OnLoadPageAsync'></a>
### OnLoadPageAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-GetcuReone-Cdo-Wpf-UiQuestion-AskQuestionYesNo-AskQuestionYesNoPage'></a>
## AskQuestionYesNoPage `type`

##### Namespace

GetcuReone.Cdo.Wpf.UiQuestion.AskQuestionYesNo

##### Summary

Interaction logic for AskQuestionYesNoPage.xaml

<a name='M-GetcuReone-Cdo-Wpf-UiQuestion-AskQuestionYesNo-AskQuestionYesNoPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Wpf-UiQuestion-AskQuestionYesNo-AskQuestionYesNoPage-InitializePageComponent``1-``0-'></a>
### InitializePageComponent\`\`1(viewModel) `method`

##### Summary



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewModel | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TViewModel |  |

<a name='T-GetcuReone-Cdo-Wpf-UiQuestion-AskQuestionYesNo-AskQuestionYesNoViewModel'></a>
## AskQuestionYesNoViewModel `type`

##### Namespace

GetcuReone.Cdo.Wpf.UiQuestion.AskQuestionYesNo

##### Summary

View-model.

<a name='P-GetcuReone-Cdo-Wpf-UiQuestion-AskQuestionYesNo-AskQuestionYesNoViewModel-No_ButtonModel'></a>
### No_ButtonModel `property`

##### Summary

Button no.

<a name='P-GetcuReone-Cdo-Wpf-UiQuestion-AskQuestionYesNo-AskQuestionYesNoViewModel-Yes_ButtonModel'></a>
### Yes_ButtonModel `property`

##### Summary

Button yes.

<a name='M-GetcuReone-Cdo-Wpf-UiQuestion-AskQuestionYesNo-AskQuestionYesNoViewModel-Initialize'></a>
### Initialize() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-GetcuReone-Cdo-Wpf-CdoWpfErrorCode'></a>
## CdoWpfErrorCode `type`

##### Namespace

GetcuReone.Cdo.Wpf

##### Summary

Error codes.

<a name='F-GetcuReone-Cdo-Wpf-CdoWpfErrorCode-InvalidSettingValue'></a>
### InvalidSettingValue `constants`

##### Summary

Invalid setting value.

<a name='F-GetcuReone-Cdo-Wpf-CdoWpfErrorCode-NotificationNotInstalled'></a>
### NotificationNotInstalled `constants`

##### Summary

Notification service not installed.

<a name='T-GetcuReone-Cdo-Wpf-FactFactory-CdoWpfRulesProvider'></a>
## CdoWpfRulesProvider `type`

##### Namespace

GetcuReone.Cdo.Wpf.FactFactory

<a name='M-GetcuReone-Cdo-Wpf-FactFactory-CdoWpfRulesProvider-GetDefaultFacts'></a>
### GetDefaultFacts() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Wpf-FactFactory-CdoWpfRulesProvider-GetRules'></a>
### GetRules() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-GetcuReone-Cdo-Wpf-UiSettings-Models-ContextModel'></a>
## ContextModel `type`

##### Namespace

GetcuReone.Cdo.Wpf.UiSettings.Models

##### Summary

Model for [SettingContext](#T-GetcuReone-Cdm-Configuration-Settings-SettingContext 'GetcuReone.Cdm.Configuration.Settings.SettingContext').

<a name='P-GetcuReone-Cdo-Wpf-UiSettings-Models-ContextModel-Description'></a>
### Description `property`

##### Summary

Description.

<a name='P-GetcuReone-Cdo-Wpf-UiSettings-Models-ContextModel-Name'></a>
### Name `property`

##### Summary

Name.

<a name='P-GetcuReone-Cdo-Wpf-UiSettings-Models-ContextModel-Namespaces'></a>
### Namespaces `property`

##### Summary

Namespaces.

<a name='T-GetcuReone-Cdo-Wpf-UiSettings-Pages-Context-ContextPage'></a>
## ContextPage `type`

##### Namespace

GetcuReone.Cdo.Wpf.UiSettings.Pages.Context

##### Summary

Interaction logic for NotificationWindowPage.xaml

<a name='M-GetcuReone-Cdo-Wpf-UiSettings-Pages-Context-ContextPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Wpf-UiSettings-Pages-Context-ContextPage-InitializePageComponent``1-``0-'></a>
### InitializePageComponent\`\`1(viewModel) `method`

##### Summary



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewModel | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TViewModel |  |

<a name='T-GetcuReone-Cdo-Wpf-UiSettings-Pages-Context-ContextViewModel'></a>
## ContextViewModel `type`

##### Namespace

GetcuReone.Cdo.Wpf.UiSettings.Pages.Context

##### Summary

View-model.

<a name='P-GetcuReone-Cdo-Wpf-UiSettings-Pages-Context-ContextViewModel-Context'></a>
### Context `property`

##### Summary

Context.

<a name='P-GetcuReone-Cdo-Wpf-UiSettings-Pages-Context-ContextViewModel-Ok_Command'></a>
### Ok_Command `property`

##### Summary

Command for [Ok](#M-GetcuReone-Cdo-Wpf-UiSettings-Pages-Context-ContextViewModel-Ok-GetcuReone-MvvmFrame-Wpf-Commands-CommandArgs- 'GetcuReone.Cdo.Wpf.UiSettings.Pages.Context.ContextViewModel.Ok(GetcuReone.MvvmFrame.Wpf.Commands.CommandArgs)')

<a name='P-GetcuReone-Cdo-Wpf-UiSettings-Pages-Context-ContextViewModel-SelectNamespace'></a>
### SelectNamespace `property`

##### Summary

Select namespace.

<a name='M-GetcuReone-Cdo-Wpf-UiSettings-Pages-Context-ContextViewModel-Initialize'></a>
### Initialize() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Wpf-UiSettings-Pages-Context-ContextViewModel-OnGoPageAsync-System-Object-'></a>
### OnGoPageAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-GetcuReone-Cdo-Wpf-OpenFileDialog-FileDialogService'></a>
## FileDialogService `type`

##### Namespace

GetcuReone.Cdo.Wpf.OpenFileDialog

##### Summary

*Inherit from parent.*

<a name='P-GetcuReone-Cdo-Wpf-OpenFileDialog-FileDialogService-FactoryName'></a>
### FactoryName `property`

##### Summary

*Inherit from parent.*

<a name='M-GetcuReone-Cdo-Wpf-OpenFileDialog-FileDialogService-SelectFiles-GetcuReone-Cdo-Wpf-OpenFileDialog-Entities-SelectFilesRequest-'></a>
### SelectFiles() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-GetcuReone-Cdo-Wpf-FileExplorer-FileExplorerAdapter'></a>
## FileExplorerAdapter `type`

##### Namespace

GetcuReone.Cdo.Wpf.FileExplorer

##### Summary

Facade for work with FileExplorer.

<a name='P-GetcuReone-Cdo-Wpf-FileExplorer-FileExplorerAdapter-AdapterName'></a>
### AdapterName `property`

##### Summary

*Inherit from parent.*

<a name='M-GetcuReone-Cdo-Wpf-FileExplorer-FileExplorerAdapter-SelectItem-System-String-'></a>
### SelectItem(pathItem) `method`

##### Summary

Opens explorer and selects an `pathItem`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pathItem | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-GetcuReone-Cdo-Wpf-OpenFileDialog-IFileDialog'></a>
## IFileDialog `type`

##### Namespace

GetcuReone.Cdo.Wpf.OpenFileDialog

##### Summary

Service for work FileExplorer

<a name='M-GetcuReone-Cdo-Wpf-OpenFileDialog-IFileDialog-SelectFiles-GetcuReone-Cdo-Wpf-OpenFileDialog-Entities-SelectFilesRequest-'></a>
### SelectFiles(request) `method`

##### Summary

Open file explorer to select files.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [GetcuReone.Cdo.Wpf.OpenFileDialog.Entities.SelectFilesRequest](#T-GetcuReone-Cdo-Wpf-OpenFileDialog-Entities-SelectFilesRequest 'GetcuReone.Cdo.Wpf.OpenFileDialog.Entities.SelectFilesRequest') | Request. |

<a name='T-GetcuReone-Cdo-Wpf-UiNotification-IUiNotification'></a>
## IUiNotification `type`

##### Namespace

GetcuReone.Cdo.Wpf.UiNotification

##### Summary

Informing interface from UI.

<a name='M-GetcuReone-Cdo-Wpf-UiNotification-IUiNotification-SendNotificationWindow-GetcuReone-Cdo-Wpf-UiNotification-Entities-UiNotificationRequest-'></a>
### SendNotificationWindow(request) `method`

##### Summary

Send notification at the top of the window.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [GetcuReone.Cdo.Wpf.UiNotification.Entities.UiNotificationRequest](#T-GetcuReone-Cdo-Wpf-UiNotification-Entities-UiNotificationRequest 'GetcuReone.Cdo.Wpf.UiNotification.Entities.UiNotificationRequest') | Request. |

<a name='T-GetcuReone-Cdo-Wpf-UiQuestion-IUiQuestion'></a>
## IUiQuestion `type`

##### Namespace

GetcuReone.Cdo.Wpf.UiQuestion

##### Summary

User polling interface through UI.

<a name='M-GetcuReone-Cdo-Wpf-UiQuestion-IUiQuestion-AskQuestionYesNoAsync-GetcuReone-Cdo-Wpf-UiQuestion-Entities-AskQuestionRequest-'></a>
### AskQuestionYesNoAsync(request) `method`

##### Summary

Ask a question (yes/no).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [GetcuReone.Cdo.Wpf.UiQuestion.Entities.AskQuestionRequest](#T-GetcuReone-Cdo-Wpf-UiQuestion-Entities-AskQuestionRequest 'GetcuReone.Cdo.Wpf.UiQuestion.Entities.AskQuestionRequest') |  |

<a name='T-GetcuReone-Cdo-Wpf-UiSettings-IUiSettings'></a>
## IUiSettings `type`

##### Namespace

GetcuReone.Cdo.Wpf.UiSettings

##### Summary

Service for UI settings.

<a name='M-GetcuReone-Cdo-Wpf-UiSettings-IUiSettings-OpenSettingsAsync-System-Collections-Generic-List{GetcuReone-Cdo-Wpf-UiSettings-Entities-SettingValueError}-'></a>
### OpenSettingsAsync(settingValueErrors) `method`

##### Summary

Open settings.

##### Returns

Changed settings.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| settingValueErrors | [System.Collections.Generic.List{GetcuReone.Cdo.Wpf.UiSettings.Entities.SettingValueError}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{GetcuReone.Cdo.Wpf.UiSettings.Entities.SettingValueError}') | (optional) |

<a name='T-GetcuReone-Cdo-Wpf-UiSettings-Models-NamespaceModel'></a>
## NamespaceModel `type`

##### Namespace

GetcuReone.Cdo.Wpf.UiSettings.Models

##### Summary

Model for [SettingNamespace](#T-GetcuReone-Cdm-Configuration-Settings-SettingNamespace 'GetcuReone.Cdm.Configuration.Settings.SettingNamespace').

<a name='P-GetcuReone-Cdo-Wpf-UiSettings-Models-NamespaceModel-Code'></a>
### Code `property`

##### Summary

Code.

<a name='P-GetcuReone-Cdo-Wpf-UiSettings-Models-NamespaceModel-Description'></a>
### Description `property`

##### Summary

Description.

<a name='P-GetcuReone-Cdo-Wpf-UiSettings-Models-NamespaceModel-Name'></a>
### Name `property`

##### Summary

Name.

<a name='P-GetcuReone-Cdo-Wpf-UiSettings-Models-NamespaceModel-NamespacePath'></a>
### NamespacePath `property`

##### Summary

Namespace path.

<a name='P-GetcuReone-Cdo-Wpf-UiSettings-Models-NamespaceModel-Settings'></a>
### Settings `property`

##### Summary

Settings.

<a name='P-GetcuReone-Cdo-Wpf-UiSettings-Models-NamespaceModel-Visibility'></a>
### Visibility `property`

##### Summary

Visibility.

<a name='T-GetcuReone-Cdo-Wpf-UiSettings-Pages-Namespace-NamespacePage'></a>
## NamespacePage `type`

##### Namespace

GetcuReone.Cdo.Wpf.UiSettings.Pages.Namespace

##### Summary

Interaction logic for NotificationWindowPage.xaml

<a name='M-GetcuReone-Cdo-Wpf-UiSettings-Pages-Namespace-NamespacePage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Wpf-UiSettings-Pages-Namespace-NamespacePage-InitializePageComponent``1-``0-'></a>
### InitializePageComponent\`\`1(viewModel) `method`

##### Summary



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewModel | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TViewModel |  |

<a name='T-GetcuReone-Cdo-Wpf-UiSettings-Pages-Namespace-NamespaceViewModel'></a>
## NamespaceViewModel `type`

##### Namespace

GetcuReone.Cdo.Wpf.UiSettings.Pages.Namespace

##### Summary

View-model

<a name='P-GetcuReone-Cdo-Wpf-UiSettings-Pages-Namespace-NamespaceViewModel-Namespace'></a>
### Namespace `property`

##### Summary

Context.

<a name='P-GetcuReone-Cdo-Wpf-UiSettings-Pages-Namespace-NamespaceViewModel-Ok_Command'></a>
### Ok_Command `property`

##### Summary

Command for [Ok](#M-GetcuReone-Cdo-Wpf-UiSettings-Pages-Namespace-NamespaceViewModel-Ok-GetcuReone-MvvmFrame-Wpf-Commands-CommandArgs- 'GetcuReone.Cdo.Wpf.UiSettings.Pages.Namespace.NamespaceViewModel.Ok(GetcuReone.MvvmFrame.Wpf.Commands.CommandArgs)')

<a name='M-GetcuReone-Cdo-Wpf-UiSettings-Pages-Namespace-NamespaceViewModel-Initialize'></a>
### Initialize() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Wpf-UiSettings-Pages-Namespace-NamespaceViewModel-OnGoPageAsync-System-Object-'></a>
### OnGoPageAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-GetcuReone-Cdo-Wpf-UiNotification-Entities-Enums-NotificationTypes'></a>
## NotificationTypes `type`

##### Namespace

GetcuReone.Cdo.Wpf.UiNotification.Entities.Enums

##### Summary

Notification types.

<a name='F-GetcuReone-Cdo-Wpf-UiNotification-Entities-Enums-NotificationTypes-Error'></a>
### Error `constants`

##### Summary

Error.

<a name='F-GetcuReone-Cdo-Wpf-UiNotification-Entities-Enums-NotificationTypes-Info'></a>
### Info `constants`

##### Summary

Info.

<a name='F-GetcuReone-Cdo-Wpf-UiNotification-Entities-Enums-NotificationTypes-Warning'></a>
### Warning `constants`

##### Summary

Warning.

<a name='T-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationVeiwModelBase'></a>
## NotificationVeiwModelBase `type`

##### Namespace

GetcuReone.Cdo.Wpf.UiNotification.UI

##### Summary

Base class for view-model ui notification.

<a name='P-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationVeiwModelBase-CloseNotification_ButtonModel'></a>
### CloseNotification_ButtonModel `property`

##### Summary

Button close notification.

<a name='P-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationVeiwModelBase-Message'></a>
### Message `property`

##### Summary

Message.

<a name='P-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationVeiwModelBase-Request'></a>
### Request `property`

##### Summary

Request.

<a name='P-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationVeiwModelBase-Title'></a>
### Title `property`

##### Summary

Title.

<a name='P-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationVeiwModelBase-Type'></a>
### Type `property`

##### Summary

Type.

<a name='P-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationVeiwModelBase-Visibility'></a>
### Visibility `property`

##### Summary

Visibility.

<a name='M-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationVeiwModelBase-GoBack'></a>
### GoBack() `method`

##### Summary

Go back.

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationVeiwModelBase-Initialize'></a>
### Initialize() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationVeiwModelBase-OnGoPageAsync-System-Object-'></a>
### OnGoPageAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationVeiwModelBase-OnLeavePageAsync-GetcuReone-MvvmFrame-Wpf-EventArgs-NavigatingEventArgs-'></a>
### OnLeavePageAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationVeiwModelBase-OnLoadPageAsync'></a>
### OnLoadPageAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationWindow-NotificationWindowPage'></a>
## NotificationWindowPage `type`

##### Namespace

GetcuReone.Cdo.Wpf.UiNotification.UI.NotificationWindow

##### Summary

Interaction logic for NotificationWindowPage.xaml

<a name='M-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationWindow-NotificationWindowPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationWindow-NotificationWindowPage-InitializePageComponent``1-``0-'></a>
### InitializePageComponent\`\`1(viewModel) `method`

##### Summary



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewModel | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TViewModel |  |

<a name='T-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationWindow-NotificationWindowViewModel'></a>
## NotificationWindowViewModel `type`

##### Namespace

GetcuReone.Cdo.Wpf.UiNotification.UI.NotificationWindow

##### Summary

View-model for [NotificationWindowPage](#T-GetcuReone-Cdo-Wpf-UiNotification-UI-NotificationWindow-NotificationWindowPage 'GetcuReone.Cdo.Wpf.UiNotification.UI.NotificationWindow.NotificationWindowPage')

<a name='T-GetcuReone-Cdo-Wpf-OpenFileDialog-OpenFileDialogAdapter'></a>
## OpenFileDialogAdapter `type`

##### Namespace

GetcuReone.Cdo.Wpf.OpenFileDialog

##### Summary

Adapter for [OpenFileDialog](#T-Microsoft-Win32-OpenFileDialog 'Microsoft.Win32.OpenFileDialog').

<a name='M-GetcuReone-Cdo-Wpf-OpenFileDialog-OpenFileDialogAdapter-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructor.

##### Parameters

This constructor has no parameters.

<a name='P-GetcuReone-Cdo-Wpf-OpenFileDialog-OpenFileDialogAdapter-AdapterName'></a>
### AdapterName `property`

##### Summary

Adapter name.

<a name='M-GetcuReone-Cdo-Wpf-OpenFileDialog-OpenFileDialogAdapter-SelectFiles-GetcuReone-Cdo-Wpf-OpenFileDialog-Entities-SelectFilesRequest-'></a>
### SelectFiles(request) `method`

##### Summary

Call Explorer to select files by user.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| request | [GetcuReone.Cdo.Wpf.OpenFileDialog.Entities.SelectFilesRequest](#T-GetcuReone-Cdo-Wpf-OpenFileDialog-Entities-SelectFilesRequest 'GetcuReone.Cdo.Wpf.OpenFileDialog.Entities.SelectFilesRequest') |  |

<a name='T-GetcuReone-Cdo-Wpf-FactFactory-Facts-UiSettings-OpenSettings_ContextModel'></a>
## OpenSettings_ContextModel `type`

##### Namespace

GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings

##### Summary

Context model.

<a name='T-GetcuReone-Cdo-Wpf-FactFactory-Facts-UiSettings-OpenSettings_NamespaceModels'></a>
## OpenSettings_NamespaceModels `type`

##### Namespace

GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings

##### Summary

List [NamespaceModel](#T-GetcuReone-Cdo-Wpf-UiSettings-Models-NamespaceModel 'GetcuReone.Cdo.Wpf.UiSettings.Models.NamespaceModel').

<a name='T-GetcuReone-Cdo-Wpf-FactFactory-Facts-UiSettings-OpenSettings_SettingModel'></a>
## OpenSettings_SettingModel `type`

##### Namespace

GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings

##### Summary

Setting model.

<a name='T-GetcuReone-Cdo-Wpf-FactFactory-Facts-UiSettings-OpenSettings_SettingModel_Setting'></a>
## OpenSettings_SettingModel_Setting `type`

##### Namespace

GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings

##### Summary

Setting.

<a name='T-GetcuReone-Cdo-Wpf-FactFactory-Facts-UiSettings-OpenSettings_SettingModel_ValidationErrors'></a>
## OpenSettings_SettingModel_ValidationErrors `type`

##### Namespace

GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings

##### Summary

Setting model validation errors.

<a name='T-GetcuReone-Cdo-Wpf-FactFactory-Facts-UiSettings-OpenSettings_SettingModels'></a>
## OpenSettings_SettingModels `type`

##### Namespace

GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings

##### Summary

List [SettingModel](#T-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel 'GetcuReone.Cdo.Wpf.UiSettings.Models.SettingModel').

<a name='T-GetcuReone-Cdo-Wpf-FactFactory-Facts-UiSettings-OpenSettings_SettingTypes'></a>
## OpenSettings_SettingTypes `type`

##### Namespace

GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings

##### Summary

Setting type list.

<a name='T-GetcuReone-Cdo-Wpf-FactFactory-Facts-UiSettings-OpenSettings_SettingValueError'></a>
## OpenSettings_SettingValueError `type`

##### Namespace

GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings

##### Summary

Error information for setting.

<a name='T-GetcuReone-Cdo-Wpf-FactFactory-Facts-UiSettings-OpenSettings_SettingValueErrors'></a>
## OpenSettings_SettingValueErrors `type`

##### Namespace

GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings

##### Summary

List [SettingValueError](#T-GetcuReone-Cdo-Wpf-UiSettings-Entities-SettingValueError 'GetcuReone.Cdo.Wpf.UiSettings.Entities.SettingValueError')

<a name='T-GetcuReone-Cdo-Wpf-FactFactory-Facts-UiSettings-OpenSettings_Settings_Changed'></a>
## OpenSettings_Settings_Changed `type`

##### Namespace

GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings

##### Summary

List of changed settings.

<a name='T-GetcuReone-Cdo-Wpf-FactFactory-Facts-UiSettings-OpenSettings_ViewModel'></a>
## OpenSettings_ViewModel `type`

##### Namespace

GetcuReone.Cdo.Wpf.FactFactory.Facts.UiSettings

##### Summary

View-model.

<a name='T-GetcuReone-Cdo-Wpf-Models-RadioButtonModel'></a>
## RadioButtonModel `type`

##### Namespace

GetcuReone.Cdo.Wpf.Models

##### Summary

*Inherit from parent.*

<a name='T-GetcuReone-Cdo-Wpf-Models-RadioButtonModel`1'></a>
## RadioButtonModel\`1 `type`

##### Namespace

GetcuReone.Cdo.Wpf.Models

##### Summary

Model for radio button

<a name='P-GetcuReone-Cdo-Wpf-Models-RadioButtonModel`1-GroupName'></a>
### GroupName `property`

##### Summary

Group name.

<a name='P-GetcuReone-Cdo-Wpf-Models-RadioButtonModel`1-IsChecked'></a>
### IsChecked `property`

##### Summary

Is checked

<a name='P-GetcuReone-Cdo-Wpf-Models-RadioButtonModel`1-Value'></a>
### Value `property`

##### Summary

Value.

<a name='T-GetcuReone-Cdo-Wpf-OpenFileDialog-Entities-SelectFilesRequest'></a>
## SelectFilesRequest `type`

##### Namespace

GetcuReone.Cdo.Wpf.OpenFileDialog.Entities

##### Summary

Request for selection files.

<a name='P-GetcuReone-Cdo-Wpf-OpenFileDialog-Entities-SelectFilesRequest-CheckFileExists'></a>
### CheckFileExists `property`

##### Summary

Gets or sets a value indicating whether the dialog box displays a warning if the user specifies a file name that does not exist.

<a name='P-GetcuReone-Cdo-Wpf-OpenFileDialog-Entities-SelectFilesRequest-Filter'></a>
### Filter `property`

##### Summary

Filter for files.

<a name='P-GetcuReone-Cdo-Wpf-OpenFileDialog-Entities-SelectFilesRequest-InitialFolder'></a>
### InitialFolder `property`

##### Summary

The path to the folder that Explorer will open by default.

<a name='P-GetcuReone-Cdo-Wpf-OpenFileDialog-Entities-SelectFilesRequest-MultiSelect'></a>
### MultiSelect `property`

##### Summary

Can I select multiple files.

<a name='P-GetcuReone-Cdo-Wpf-OpenFileDialog-Entities-SelectFilesRequest-TitleDialog'></a>
### TitleDialog `property`

##### Summary

Title dialog.

<a name='T-GetcuReone-Cdo-Wpf-OpenFileDialog-Entities-SelectFilesResult'></a>
## SelectFilesResult `type`

##### Namespace

GetcuReone.Cdo.Wpf.OpenFileDialog.Entities

##### Summary

Result for selection files.

<a name='P-GetcuReone-Cdo-Wpf-OpenFileDialog-Entities-SelectFilesResult-ResultShowDialog'></a>
### ResultShowDialog `property`

##### Summary

Dilog show result.

<a name='P-GetcuReone-Cdo-Wpf-OpenFileDialog-Entities-SelectFilesResult-SelectedFiles'></a>
### SelectedFiles `property`

##### Summary

Selected files.

<a name='T-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel'></a>
## SettingModel `type`

##### Namespace

GetcuReone.Cdo.Wpf.UiSettings.Models

##### Summary

Setting model.

<a name='P-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel-Code'></a>
### Code `property`

##### Summary

Code.

<a name='P-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel-Description'></a>
### Description `property`

##### Summary

Description.

<a name='P-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel-Name'></a>
### Name `property`

##### Summary

Name.

<a name='P-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel-PermissibleValues'></a>
### PermissibleValues `property`

##### Summary

Permissible values.

<a name='P-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel-PermissibleValuesIsEnabled'></a>
### PermissibleValuesIsEnabled `property`

##### Summary

IsEnubled [PermissibleValues](#P-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel-PermissibleValues 'GetcuReone.Cdo.Wpf.UiSettings.Models.SettingModel.PermissibleValues').

<a name='P-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel-PermissibleValuesVisibility'></a>
### PermissibleValuesVisibility `property`

##### Summary

Visibility [PermissibleValues](#P-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel-PermissibleValues 'GetcuReone.Cdo.Wpf.UiSettings.Models.SettingModel.PermissibleValues')

<a name='P-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel-TextBoxVisibility'></a>
### TextBoxVisibility `property`

##### Summary

Visibility textbox

<a name='P-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel-Value'></a>
### Value `property`

##### Summary

Value.

<a name='M-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel-Initialize'></a>
### Initialize() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel-OnErrors-System-Collections-ObjectModel-ReadOnlyCollection{GetcuReone-MvvmFrame-Entities-MvvmFrameErrorDetail}-'></a>
### OnErrors() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdo-Wpf-UiSettings-Models-SettingModel-OnVerification-GetcuReone-MvvmFrame-EventArgs-MvvmElementPropertyVerifyChangeEventArgs-'></a>
### OnVerification() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-GetcuReone-Cdo-Wpf-UiSettings-Entities-SettingValueError'></a>
## SettingValueError `type`

##### Namespace

GetcuReone.Cdo.Wpf.UiSettings.Entities

##### Summary

Setting validation error text

<a name='P-GetcuReone-Cdo-Wpf-UiSettings-Entities-SettingValueError-ErrorMessage'></a>
### ErrorMessage `property`

##### Summary

Error message.

<a name='P-GetcuReone-Cdo-Wpf-UiSettings-Entities-SettingValueError-SettingFullCode'></a>
### SettingFullCode `property`

##### Summary

[FullCode](#P-GetcuReone-Cdm-Configuration-Settings-Setting-FullCode 'GetcuReone.Cdm.Configuration.Settings.Setting.FullCode').

<a name='T-GetcuReone-Cdo-Wpf-Models-TextModel'></a>
## TextModel `type`

##### Namespace

GetcuReone.Cdo.Wpf.Models

##### Summary

Model for text.

<a name='P-GetcuReone-Cdo-Wpf-Models-TextModel-Text'></a>
### Text `property`

##### Summary

Text.

<a name='P-GetcuReone-Cdo-Wpf-Models-TextModel-Visibility'></a>
### Visibility `property`

##### Summary

Visibility text.

<a name='T-GetcuReone-Cdo-Wpf-UiNotification-Entities-UiNotificationRequest'></a>
## UiNotificationRequest `type`

##### Namespace

GetcuReone.Cdo.Wpf.UiNotification.Entities

##### Summary

Request.

<a name='P-GetcuReone-Cdo-Wpf-UiNotification-Entities-UiNotificationRequest-Message'></a>
### Message `property`

##### Summary

Notification message.

<a name='P-GetcuReone-Cdo-Wpf-UiNotification-Entities-UiNotificationRequest-Title'></a>
### Title `property`

##### Summary

Notification title.

<a name='P-GetcuReone-Cdo-Wpf-UiNotification-Entities-UiNotificationRequest-Type'></a>
### Type `property`

##### Summary

Notification type.

<a name='T-GetcuReone-Cdo-Wpf-UiNotification-UiNotificationSetupHelper'></a>
## UiNotificationSetupHelper `type`

##### Namespace

GetcuReone.Cdo.Wpf.UiNotification

##### Summary

Installation Notification Instance Assistant

<a name='M-GetcuReone-Cdo-Wpf-UiNotification-UiNotificationSetupHelper-SetupUiNitification``1-``0,System-Windows-Controls-Frame-'></a>
### SetupUiNitification\`\`1(configUi,frame) `method`

##### Summary

Install notification service.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configUi | [\`\`0](#T-``0 '``0') |  |
| frame | [System.Windows.Controls.Frame](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.Frame 'System.Windows.Controls.Frame') | Frame for bind. |

<a name='T-GetcuReone-Cdo-Wpf-UiQuestion-UiQuestionSetupHelper'></a>
## UiQuestionSetupHelper `type`

##### Namespace

GetcuReone.Cdo.Wpf.UiQuestion

##### Summary

Installation Notification Instance Assistant.

<a name='M-GetcuReone-Cdo-Wpf-UiQuestion-UiQuestionSetupHelper-SetupUiQuestion``1-``0,System-Windows-Controls-Frame-'></a>
### SetupUiQuestion\`\`1(configUi,frame) `method`

##### Summary

Install question service.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configUi | [\`\`0](#T-``0 '``0') |  |
| frame | [System.Windows.Controls.Frame](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.Frame 'System.Windows.Controls.Frame') | Frame for bind. |

<a name='T-GetcuReone-Cdo-Wpf-UiSettings-UiSettingsSetupHelper'></a>
## UiSettingsSetupHelper `type`

##### Namespace

GetcuReone.Cdo.Wpf.UiSettings

##### Summary

Setup helper.

<a name='M-GetcuReone-Cdo-Wpf-UiSettings-UiSettingsSetupHelper-SetupUiSettings``1-``0,System-Windows-Controls-Frame-'></a>
### SetupUiSettings\`\`1(configUi,frame) `method`

##### Summary

Install [IUiSettings](#T-GetcuReone-Cdo-Wpf-UiSettings-IUiSettings 'GetcuReone.Cdo.Wpf.UiSettings.IUiSettings').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configUi | [\`\`0](#T-``0 '``0') |  |
| frame | [System.Windows.Controls.Frame](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.Frame 'System.Windows.Controls.Frame') | Frame for bind. |
