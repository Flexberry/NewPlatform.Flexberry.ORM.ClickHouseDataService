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
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Берлога.
    /// </summary>
    // *** Start programmer edit section *** (Берлога CustomAttributes)

    // *** End programmer edit section *** (Берлога CustomAttributes)
    [BusinessServer("NewPlatform.ClickHouseDataService.Tests.БерлогаБС, ClickHouseDataService.Tests.Bu" +
        "sinessServers", ICSSoft.STORMNET.Business.DataServiceObjectEvents.OnAllEvents)]
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("LoadTestView", new string[] {
            "Наименование"})]
    [View("БерлогаE", new string[] {
            "Наименование as \'Наименование\'",
            "Комфортность as \'Комфортность\'",
            "Заброшена as \'Заброшена\'",
            "ЛесРасположения as \'Лес расположения\'",
            "ЛесРасположения.Название as \'Название\'"}, Hidden=new string[] {
            "ЛесРасположения.Название"})]
    [MasterViewDefineAttribute("БерлогаE", "ЛесРасположения", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Название")]
    public class Берлога : ICSSoft.STORMNET.DataObject
    {
        
        private string fНаименование;
        
        private int fКомфортность;
        
        private bool fЗаброшена;
        
        private NewPlatform.ClickHouseDataService.Tests.Лес fЛесРасположения;
        
        private NewPlatform.ClickHouseDataService.Tests.Медведь fМедведь;
        
        // *** Start programmer edit section *** (Берлога CustomMembers)

        // *** End programmer edit section *** (Берлога CustomMembers)

        
        /// <summary>
        /// Наименование.
        /// </summary>
        // *** Start programmer edit section *** (Берлога.Наименование CustomAttributes)

        // *** End programmer edit section *** (Берлога.Наименование CustomAttributes)
        [StrLen(255)]
        public virtual string Наименование
        {
            get
            {
                // *** Start programmer edit section *** (Берлога.Наименование Get start)

                // *** End programmer edit section *** (Берлога.Наименование Get start)
                string result = this.fНаименование;
                // *** Start programmer edit section *** (Берлога.Наименование Get end)

                // *** End programmer edit section *** (Берлога.Наименование Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Берлога.Наименование Set start)

                // *** End programmer edit section *** (Берлога.Наименование Set start)
                this.fНаименование = value;
                // *** Start programmer edit section *** (Берлога.Наименование Set end)

                // *** End programmer edit section *** (Берлога.Наименование Set end)
            }
        }
        
        /// <summary>
        /// Комфортность.
        /// </summary>
        // *** Start programmer edit section *** (Берлога.Комфортность CustomAttributes)

        // *** End programmer edit section *** (Берлога.Комфортность CustomAttributes)
        public virtual int Комфортность
        {
            get
            {
                // *** Start programmer edit section *** (Берлога.Комфортность Get start)

                // *** End programmer edit section *** (Берлога.Комфортность Get start)
                int result = this.fКомфортность;
                // *** Start programmer edit section *** (Берлога.Комфортность Get end)

                // *** End programmer edit section *** (Берлога.Комфортность Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Берлога.Комфортность Set start)

                // *** End programmer edit section *** (Берлога.Комфортность Set start)
                this.fКомфортность = value;
                // *** Start programmer edit section *** (Берлога.Комфортность Set end)

                // *** End programmer edit section *** (Берлога.Комфортность Set end)
            }
        }
        
        /// <summary>
        /// Заброшена.
        /// </summary>
        // *** Start programmer edit section *** (Берлога.Заброшена CustomAttributes)

        // *** End programmer edit section *** (Берлога.Заброшена CustomAttributes)
        public virtual bool Заброшена
        {
            get
            {
                // *** Start programmer edit section *** (Берлога.Заброшена Get start)

                // *** End programmer edit section *** (Берлога.Заброшена Get start)
                bool result = this.fЗаброшена;
                // *** Start programmer edit section *** (Берлога.Заброшена Get end)

                // *** End programmer edit section *** (Берлога.Заброшена Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Берлога.Заброшена Set start)

                // *** End programmer edit section *** (Берлога.Заброшена Set start)
                this.fЗаброшена = value;
                // *** Start programmer edit section *** (Берлога.Заброшена Set end)

                // *** End programmer edit section *** (Берлога.Заброшена Set end)
            }
        }
        
        /// <summary>
        /// Берлога.
        /// </summary>
        // *** Start programmer edit section *** (Берлога.ЛесРасположения CustomAttributes)

        // *** End programmer edit section *** (Берлога.ЛесРасположения CustomAttributes)
        [PropertyStorage(new string[] {
                "ЛесРасположения"})]
        public virtual NewPlatform.ClickHouseDataService.Tests.Лес ЛесРасположения
        {
            get
            {
                // *** Start programmer edit section *** (Берлога.ЛесРасположения Get start)

                // *** End programmer edit section *** (Берлога.ЛесРасположения Get start)
                NewPlatform.ClickHouseDataService.Tests.Лес result = this.fЛесРасположения;
                // *** Start programmer edit section *** (Берлога.ЛесРасположения Get end)

                // *** End programmer edit section *** (Берлога.ЛесРасположения Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Берлога.ЛесРасположения Set start)

                // *** End programmer edit section *** (Берлога.ЛесРасположения Set start)
                this.fЛесРасположения = value;
                // *** Start programmer edit section *** (Берлога.ЛесРасположения Set end)

                // *** End programmer edit section *** (Берлога.ЛесРасположения Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку NewPlatform.ClickHouseDataService.Tests.Медведь.
        /// </summary>
        // *** Start programmer edit section *** (Берлога.Медведь CustomAttributes)

        // *** End programmer edit section *** (Берлога.Медведь CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "Медведь"})]
        public virtual NewPlatform.ClickHouseDataService.Tests.Медведь Медведь
        {
            get
            {
                // *** Start programmer edit section *** (Берлога.Медведь Get start)

                // *** End programmer edit section *** (Берлога.Медведь Get start)
                NewPlatform.ClickHouseDataService.Tests.Медведь result = this.fМедведь;
                // *** Start programmer edit section *** (Берлога.Медведь Get end)

                // *** End programmer edit section *** (Берлога.Медведь Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Берлога.Медведь Set start)

                // *** End programmer edit section *** (Берлога.Медведь Set start)
                this.fМедведь = value;
                // *** Start programmer edit section *** (Берлога.Медведь Set end)

                // *** End programmer edit section *** (Берлога.Медведь Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// Представление для работы тестов на загрузку объектов.
            /// </summary>
            public static ICSSoft.STORMNET.View LoadTestView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("LoadTestView", typeof(NewPlatform.ClickHouseDataService.Tests.Берлога));
                }
            }
            
            /// <summary>
            /// "БерлогаE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View БерлогаE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("БерлогаE", typeof(NewPlatform.ClickHouseDataService.Tests.Берлога));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of Берлога.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfБерлога CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfБерлога CustomAttributes)
    public class DetailArrayOfБерлога : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (NewPlatform.ClickHouseDataService.Tests.DetailArrayOfБерлога members)

        // *** End programmer edit section *** (NewPlatform.ClickHouseDataService.Tests.DetailArrayOfБерлога members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type Берлога by index.
        /// </summary>
        /// <summary>
        /// Adds object with type Берлога.
        /// </summary>
        public DetailArrayOfБерлога(NewPlatform.ClickHouseDataService.Tests.Медведь fМедведь) : 
                base(typeof(Берлога), ((ICSSoft.STORMNET.DataObject)(fМедведь)))
        {
        }
        
        public NewPlatform.ClickHouseDataService.Tests.Берлога this[int index]
        {
            get
            {
                return ((NewPlatform.ClickHouseDataService.Tests.Берлога)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(NewPlatform.ClickHouseDataService.Tests.Берлога dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
