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
    /// ЭтапИсходящегоЗапроса.
    /// </summary>
    // *** Start programmer edit section *** (ЭтапИсходящегоЗапроса CustomAttributes)

    // *** End programmer edit section *** (ЭтапИсходящегоЗапроса CustomAttributes)
    [AutoAltered()]
    [ICSSoft.STORMNET.NotStored()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class ЭтапИсходящегоЗапроса : ICSSoft.STORMNET.DataObject
    {
        
        private NewPlatform.ClickHouseDataService.Tests.СтатусЗапроса fСтатус;
        
        private NewPlatform.ClickHouseDataService.Tests.КонфигурацияЗапроса fКонфигурация;
        
        private NewPlatform.ClickHouseDataService.Tests.ИсходящийЗапрос fЗапросы;
        
        // *** Start programmer edit section *** (ЭтапИсходящегоЗапроса CustomMembers)

        // *** End programmer edit section *** (ЭтапИсходящегоЗапроса CustomMembers)

        
        /// <summary>
        /// Статус.
        /// </summary>
        // *** Start programmer edit section *** (ЭтапИсходящегоЗапроса.Статус CustomAttributes)

        // *** End programmer edit section *** (ЭтапИсходящегоЗапроса.Статус CustomAttributes)
        public virtual NewPlatform.ClickHouseDataService.Tests.СтатусЗапроса Статус
        {
            get
            {
                // *** Start programmer edit section *** (ЭтапИсходящегоЗапроса.Статус Get start)

                // *** End programmer edit section *** (ЭтапИсходящегоЗапроса.Статус Get start)
                NewPlatform.ClickHouseDataService.Tests.СтатусЗапроса result = this.fСтатус;
                // *** Start programmer edit section *** (ЭтапИсходящегоЗапроса.Статус Get end)

                // *** End programmer edit section *** (ЭтапИсходящегоЗапроса.Статус Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЭтапИсходящегоЗапроса.Статус Set start)

                // *** End programmer edit section *** (ЭтапИсходящегоЗапроса.Статус Set start)
                this.fСтатус = value;
                // *** Start programmer edit section *** (ЭтапИсходящегоЗапроса.Статус Set end)

                // *** End programmer edit section *** (ЭтапИсходящегоЗапроса.Статус Set end)
            }
        }
        
        /// <summary>
        /// ЭтапИсходящегоЗапроса.
        /// </summary>
        // *** Start programmer edit section *** (ЭтапИсходящегоЗапроса.Конфигурация CustomAttributes)

        // *** End programmer edit section *** (ЭтапИсходящегоЗапроса.Конфигурация CustomAttributes)
        [PropertyStorage(new string[] {
                "Конфигурация"})]
        [NotNull()]
        public virtual NewPlatform.ClickHouseDataService.Tests.КонфигурацияЗапроса Конфигурация
        {
            get
            {
                // *** Start programmer edit section *** (ЭтапИсходящегоЗапроса.Конфигурация Get start)

                // *** End programmer edit section *** (ЭтапИсходящегоЗапроса.Конфигурация Get start)
                NewPlatform.ClickHouseDataService.Tests.КонфигурацияЗапроса result = this.fКонфигурация;
                // *** Start programmer edit section *** (ЭтапИсходящегоЗапроса.Конфигурация Get end)

                // *** End programmer edit section *** (ЭтапИсходящегоЗапроса.Конфигурация Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЭтапИсходящегоЗапроса.Конфигурация Set start)

                // *** End programmer edit section *** (ЭтапИсходящегоЗапроса.Конфигурация Set start)
                this.fКонфигурация = value;
                // *** Start programmer edit section *** (ЭтапИсходящегоЗапроса.Конфигурация Set end)

                // *** End programmer edit section *** (ЭтапИсходящегоЗапроса.Конфигурация Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку NewPlatform.ClickHouseDataService.Tests.ИсходящийЗапрос.
        /// </summary>
        // *** Start programmer edit section *** (ЭтапИсходящегоЗапроса.Запросы CustomAttributes)

        // *** End programmer edit section *** (ЭтапИсходящегоЗапроса.Запросы CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "Запросы"})]
        public virtual NewPlatform.ClickHouseDataService.Tests.ИсходящийЗапрос Запросы
        {
            get
            {
                // *** Start programmer edit section *** (ЭтапИсходящегоЗапроса.Запросы Get start)

                // *** End programmer edit section *** (ЭтапИсходящегоЗапроса.Запросы Get start)
                NewPlatform.ClickHouseDataService.Tests.ИсходящийЗапрос result = this.fЗапросы;
                // *** Start programmer edit section *** (ЭтапИсходящегоЗапроса.Запросы Get end)

                // *** End programmer edit section *** (ЭтапИсходящегоЗапроса.Запросы Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ЭтапИсходящегоЗапроса.Запросы Set start)

                // *** End programmer edit section *** (ЭтапИсходящегоЗапроса.Запросы Set start)
                this.fЗапросы = value;
                // *** Start programmer edit section *** (ЭтапИсходящегоЗапроса.Запросы Set end)

                // *** End programmer edit section *** (ЭтапИсходящегоЗапроса.Запросы Set end)
            }
        }
    }
    
    /// <summary>
    /// Detail array of ЭтапИсходящегоЗапроса.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfЭтапИсходящегоЗапроса CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfЭтапИсходящегоЗапроса CustomAttributes)
    public class DetailArrayOfЭтапИсходящегоЗапроса : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (NewPlatform.ClickHouseDataService.Tests.DetailArrayOfЭтапИсходящегоЗапроса members)

        // *** End programmer edit section *** (NewPlatform.ClickHouseDataService.Tests.DetailArrayOfЭтапИсходящегоЗапроса members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type ЭтапИсходящегоЗапроса by index.
        /// </summary>
        /// <summary>
        /// Adds object with type ЭтапИсходящегоЗапроса.
        /// </summary>
        public DetailArrayOfЭтапИсходящегоЗапроса(NewPlatform.ClickHouseDataService.Tests.ИсходящийЗапрос fИсходящийЗапрос) : 
                base(typeof(ЭтапИсходящегоЗапроса), ((ICSSoft.STORMNET.DataObject)(fИсходящийЗапрос)))
        {
        }
        
        public NewPlatform.ClickHouseDataService.Tests.ЭтапИсходящегоЗапроса this[int index]
        {
            get
            {
                return ((NewPlatform.ClickHouseDataService.Tests.ЭтапИсходящегоЗапроса)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(NewPlatform.ClickHouseDataService.Tests.ЭтапИсходящегоЗапроса dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
