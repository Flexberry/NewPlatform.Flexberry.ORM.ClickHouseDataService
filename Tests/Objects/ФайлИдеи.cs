﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// ФайлИдеи.
    /// </summary>
    // *** Start programmer edit section *** (ФайлИдеи CustomAttributes)

    // *** End programmer edit section *** (ФайлИдеи CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ФайлE", new string[] {
            "Файл",
            "Владелец"})]
    public class ФайлИдеи : ICSSoft.STORMNET.DataObject
    {
        
        private ICSSoft.STORMNET.UserDataTypes.WebFile fФайл;
        
        private NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Пользователь fВладелец;
        
        private NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Идея fИдея;
        
        // *** Start programmer edit section *** (ФайлИдеи CustomMembers)

        // *** End programmer edit section *** (ФайлИдеи CustomMembers)

        
        /// <summary>
        /// Файл.
        /// </summary>
        // *** Start programmer edit section *** (ФайлИдеи.Файл CustomAttributes)

        // *** End programmer edit section *** (ФайлИдеи.Файл CustomAttributes)
        public virtual ICSSoft.STORMNET.UserDataTypes.WebFile Файл
        {
            get
            {
                // *** Start programmer edit section *** (ФайлИдеи.Файл Get start)

                // *** End programmer edit section *** (ФайлИдеи.Файл Get start)
                ICSSoft.STORMNET.UserDataTypes.WebFile result = this.fФайл;
                // *** Start programmer edit section *** (ФайлИдеи.Файл Get end)

                // *** End programmer edit section *** (ФайлИдеи.Файл Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ФайлИдеи.Файл Set start)

                // *** End programmer edit section *** (ФайлИдеи.Файл Set start)
                this.fФайл = value;
                // *** Start programmer edit section *** (ФайлИдеи.Файл Set end)

                // *** End programmer edit section *** (ФайлИдеи.Файл Set end)
            }
        }
        
        /// <summary>
        /// ФайлИдеи.
        /// </summary>
        // *** Start programmer edit section *** (ФайлИдеи.Владелец CustomAttributes)

        // *** End programmer edit section *** (ФайлИдеи.Владелец CustomAttributes)
        [NotNull()]
        public virtual NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Пользователь Владелец
        {
            get
            {
                // *** Start programmer edit section *** (ФайлИдеи.Владелец Get start)

                // *** End programmer edit section *** (ФайлИдеи.Владелец Get start)
                NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Пользователь result = this.fВладелец;
                // *** Start programmer edit section *** (ФайлИдеи.Владелец Get end)

                // *** End programmer edit section *** (ФайлИдеи.Владелец Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ФайлИдеи.Владелец Set start)

                // *** End programmer edit section *** (ФайлИдеи.Владелец Set start)
                this.fВладелец = value;
                // *** Start programmer edit section *** (ФайлИдеи.Владелец Set end)

                // *** End programmer edit section *** (ФайлИдеи.Владелец Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Идея.
        /// </summary>
        // *** Start programmer edit section *** (ФайлИдеи.Идея CustomAttributes)

        // *** End programmer edit section *** (ФайлИдеи.Идея CustomAttributes)
        [Agregator()]
        [NotNull()]
        public virtual NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Идея Идея
        {
            get
            {
                // *** Start programmer edit section *** (ФайлИдеи.Идея Get start)

                // *** End programmer edit section *** (ФайлИдеи.Идея Get start)
                NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Идея result = this.fИдея;
                // *** Start programmer edit section *** (ФайлИдеи.Идея Get end)

                // *** End programmer edit section *** (ФайлИдеи.Идея Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ФайлИдеи.Идея Set start)

                // *** End programmer edit section *** (ФайлИдеи.Идея Set start)
                this.fИдея = value;
                // *** Start programmer edit section *** (ФайлИдеи.Идея Set end)

                // *** End programmer edit section *** (ФайлИдеи.Идея Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ФайлE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ФайлE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ФайлE", typeof(NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.ФайлИдеи));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of ФайлИдеи.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfФайлИдеи CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfФайлИдеи CustomAttributes)
    public class DetailArrayOfФайлИдеи : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.DetailArrayOfФайлИдеи members)

        // *** End programmer edit section *** (NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.DetailArrayOfФайлИдеи members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type ФайлИдеи by index.
        /// </summary>
        /// <summary>
        /// Adds object with type ФайлИдеи.
        /// </summary>
        public DetailArrayOfФайлИдеи(NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Идея fИдея) : 
                base(typeof(ФайлИдеи), ((ICSSoft.STORMNET.DataObject)(fИдея)))
        {
        }
        
        public NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.ФайлИдеи this[int index]
        {
            get
            {
                return ((NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.ФайлИдеи)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.ФайлИдеи dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
