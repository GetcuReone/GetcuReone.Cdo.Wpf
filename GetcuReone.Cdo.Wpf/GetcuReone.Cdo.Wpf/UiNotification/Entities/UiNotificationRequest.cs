﻿using GetcuReone.Cdo.UiNotification.Entities.Enums;

namespace GetcuReone.Cdo.UiNotification.Entities
{
    /// <summary>
    /// Request.
    /// </summary>
    public class UiNotificationRequest
    {
        /// <summary>
        /// Notification title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Notification message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Notification type.
        /// </summary>
        public NotificationTypes Type { get; set; }
    }
}
