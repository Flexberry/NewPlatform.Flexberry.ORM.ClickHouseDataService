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
    /// ТипПороды.
    /// </summary>
    // *** Start programmer edit section *** (ТипПороды CustomAttributes)

    // *** End programmer edit section *** (ТипПороды CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ТипПородыE", new string[] {
            "Название",
            "ДатаРегистрации"})]
    [View("ТипПородыL", new string[] {
            "Название",
            "ДатаРегистрации"})]
    public class ТипПороды : ICSSoft.STORMNET.DataObject
    {
        
        private string fНазвание;
        
        private System.DateTime fДатаРегистрации;
        
        // *** Start programmer edit section *** (ТипПороды CustomMembers)

        // *** End programmer edit section *** (ТипПороды CustomMembers)

        
        /// <summary>
        /// Название.
        /// </summary>
        // *** Start programmer edit section *** (ТипПороды.Название CustomAttributes)

        // *** End programmer edit section *** (ТипПороды.Название CustomAttributes)
        [StrLen(255)]
        public virtual string Название
        {
            get
            {
                // *** Start programmer edit section *** (ТипПороды.Название Get start)

                // *** End programmer edit section *** (ТипПороды.Название Get start)
                string result = this.fНазвание;
                // *** Start programmer edit section *** (ТипПороды.Название Get end)

                // *** End programmer edit section *** (ТипПороды.Название Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТипПороды.Название Set start)

                // *** End programmer edit section *** (ТипПороды.Название Set start)
                this.fНазвание = value;
                // *** Start programmer edit section *** (ТипПороды.Название Set end)

                // *** End programmer edit section *** (ТипПороды.Название Set end)
            }
        }
        
        /// <summary>
        /// ДатаРегистрации.
        /// </summary>
        // *** Start programmer edit section *** (ТипПороды.ДатаРегистрации CustomAttributes)

        // *** End programmer edit section *** (ТипПороды.ДатаРегистрации CustomAttributes)
        public virtual System.DateTime ДатаРегистрации
        {
            get
            {
                // *** Start programmer edit section *** (ТипПороды.ДатаРегистрации Get start)

                // *** End programmer edit section *** (ТипПороды.ДатаРегистрации Get start)
                System.DateTime result = this.fДатаРегистрации;
                // *** Start programmer edit section *** (ТипПороды.ДатаРегистрации Get end)

                // *** End programmer edit section *** (ТипПороды.ДатаРегистрации Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТипПороды.ДатаРегистрации Set start)

                // *** End programmer edit section *** (ТипПороды.ДатаРегистрации Set start)
                this.fДатаРегистрации = value;
                // *** Start programmer edit section *** (ТипПороды.ДатаРегистрации Set end)

                // *** End programmer edit section *** (ТипПороды.ДатаРегистрации Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ТипПородыE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ТипПородыE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ТипПородыE", typeof(NewPlatform.ClickHouseDataService.Tests.ТипПороды));
                }
            }
            
            /// <summary>
            /// "ТипПородыL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ТипПородыL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ТипПородыL", typeof(NewPlatform.ClickHouseDataService.Tests.ТипПороды));
                }
            }
        }
    }
}
