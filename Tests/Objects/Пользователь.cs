﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.ClickHouseDataService.Tests
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Пользователь.
    /// </summary>
    // *** Start programmer edit section *** (Пользователь CustomAttributes)

    // *** End programmer edit section *** (Пользователь CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ПользовательE", new string[] {
            "Логин",
            "ФИО",
            "EMail",
            "ДатаРегистрации"})]
    public class Пользователь : ICSSoft.STORMNET.DataObject
    {
        
        private string fЛогин;
        
        private string fФИО;
        
        private string fEMail;
        
        private ICSSoft.STORMNET.UserDataTypes.NullableDateTime fДатаРегистрации = ICSSoft.STORMNET.UserDataTypes.NullableDateTime.Now;
        
        // *** Start programmer edit section *** (Пользователь CustomMembers)

        // *** End programmer edit section *** (Пользователь CustomMembers)

        
        /// <summary>
        /// Логин.
        /// </summary>
        // *** Start programmer edit section *** (Пользователь.Логин CustomAttributes)

        // *** End programmer edit section *** (Пользователь.Логин CustomAttributes)
        [StrLen(255)]
        public virtual string Логин
        {
            get
            {
                // *** Start programmer edit section *** (Пользователь.Логин Get start)

                // *** End programmer edit section *** (Пользователь.Логин Get start)
                string result = this.fЛогин;
                // *** Start programmer edit section *** (Пользователь.Логин Get end)

                // *** End programmer edit section *** (Пользователь.Логин Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Пользователь.Логин Set start)

                // *** End programmer edit section *** (Пользователь.Логин Set start)
                this.fЛогин = value;
                // *** Start programmer edit section *** (Пользователь.Логин Set end)

                // *** End programmer edit section *** (Пользователь.Логин Set end)
            }
        }
        
        /// <summary>
        /// ФИО.
        /// </summary>
        // *** Start programmer edit section *** (Пользователь.ФИО CustomAttributes)

        // *** End programmer edit section *** (Пользователь.ФИО CustomAttributes)
        [StrLen(255)]
        public virtual string ФИО
        {
            get
            {
                // *** Start programmer edit section *** (Пользователь.ФИО Get start)

                // *** End programmer edit section *** (Пользователь.ФИО Get start)
                string result = this.fФИО;
                // *** Start programmer edit section *** (Пользователь.ФИО Get end)

                // *** End programmer edit section *** (Пользователь.ФИО Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Пользователь.ФИО Set start)

                // *** End programmer edit section *** (Пользователь.ФИО Set start)
                this.fФИО = value;
                // *** Start programmer edit section *** (Пользователь.ФИО Set end)

                // *** End programmer edit section *** (Пользователь.ФИО Set end)
            }
        }
        
        /// <summary>
        /// EMail.
        /// </summary>
        // *** Start programmer edit section *** (Пользователь.EMail CustomAttributes)

        // *** End programmer edit section *** (Пользователь.EMail CustomAttributes)
        [StrLen(255)]
        public virtual string EMail
        {
            get
            {
                // *** Start programmer edit section *** (Пользователь.EMail Get start)

                // *** End programmer edit section *** (Пользователь.EMail Get start)
                string result = this.fEMail;
                // *** Start programmer edit section *** (Пользователь.EMail Get end)

                // *** End programmer edit section *** (Пользователь.EMail Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Пользователь.EMail Set start)

                // *** End programmer edit section *** (Пользователь.EMail Set start)
                this.fEMail = value;
                // *** Start programmer edit section *** (Пользователь.EMail Set end)

                // *** End programmer edit section *** (Пользователь.EMail Set end)
            }
        }
        
        /// <summary>
        /// ДатаРегистрации.
        /// </summary>
        // *** Start programmer edit section *** (Пользователь.ДатаРегистрации CustomAttributes)

        // *** End programmer edit section *** (Пользователь.ДатаРегистрации CustomAttributes)
        public virtual ICSSoft.STORMNET.UserDataTypes.NullableDateTime ДатаРегистрации
        {
            get
            {
                // *** Start programmer edit section *** (Пользователь.ДатаРегистрации Get start)

                // *** End programmer edit section *** (Пользователь.ДатаРегистрации Get start)
                ICSSoft.STORMNET.UserDataTypes.NullableDateTime result = this.fДатаРегистрации;
                // *** Start programmer edit section *** (Пользователь.ДатаРегистрации Get end)

                // *** End programmer edit section *** (Пользователь.ДатаРегистрации Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Пользователь.ДатаРегистрации Set start)

                // *** End programmer edit section *** (Пользователь.ДатаРегистрации Set start)
                this.fДатаРегистрации = value;
                // *** Start programmer edit section *** (Пользователь.ДатаРегистрации Set end)

                // *** End programmer edit section *** (Пользователь.ДатаРегистрации Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ПользовательE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ПользовательE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ПользовательE", typeof(NewPlatform.ClickHouseDataService.Tests.Пользователь));
                }
            }
        }
    }
}
