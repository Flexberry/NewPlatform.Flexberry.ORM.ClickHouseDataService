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
    /// Cabbage part2.
    /// </summary>
    // *** Start programmer edit section *** (CabbagePart2 CustomAttributes)

    // *** End programmer edit section *** (CabbagePart2 CustomAttributes)
    [AutoAltered()]
    [Caption("Cabbage part2")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("CabbagePart2E", new string[] {
            "PartName as \'Part name\'"})]
    public class CabbagePart2 : ICSSoft.STORMNET.DataObject
    {
        
        private string fPartName;
        
        private NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Cabbage2 fCabbage;
        
        // *** Start programmer edit section *** (CabbagePart2 CustomMembers)

        // *** End programmer edit section *** (CabbagePart2 CustomMembers)

        
        /// <summary>
        /// PartName.
        /// </summary>
        // *** Start programmer edit section *** (CabbagePart2.PartName CustomAttributes)

        // *** End programmer edit section *** (CabbagePart2.PartName CustomAttributes)
        [StrLen(255)]
        public virtual string PartName
        {
            get
            {
                // *** Start programmer edit section *** (CabbagePart2.PartName Get start)

                // *** End programmer edit section *** (CabbagePart2.PartName Get start)
                string result = this.fPartName;
                // *** Start programmer edit section *** (CabbagePart2.PartName Get end)

                // *** End programmer edit section *** (CabbagePart2.PartName Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (CabbagePart2.PartName Set start)

                // *** End programmer edit section *** (CabbagePart2.PartName Set start)
                this.fPartName = value;
                // *** Start programmer edit section *** (CabbagePart2.PartName Set end)

                // *** End programmer edit section *** (CabbagePart2.PartName Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Cabbage2.
        /// </summary>
        // *** Start programmer edit section *** (CabbagePart2.Cabbage CustomAttributes)

        // *** End programmer edit section *** (CabbagePart2.Cabbage CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "Cabbage"})]
        public virtual NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Cabbage2 Cabbage
        {
            get
            {
                // *** Start programmer edit section *** (CabbagePart2.Cabbage Get start)

                // *** End programmer edit section *** (CabbagePart2.Cabbage Get start)
                NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Cabbage2 result = this.fCabbage;
                // *** Start programmer edit section *** (CabbagePart2.Cabbage Get end)

                // *** End programmer edit section *** (CabbagePart2.Cabbage Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (CabbagePart2.Cabbage Set start)

                // *** End programmer edit section *** (CabbagePart2.Cabbage Set start)
                this.fCabbage = value;
                // *** Start programmer edit section *** (CabbagePart2.Cabbage Set end)

                // *** End programmer edit section *** (CabbagePart2.Cabbage Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "CabbagePart2E" view.
            /// </summary>
            public static ICSSoft.STORMNET.View CabbagePart2E
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("CabbagePart2E", typeof(NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.CabbagePart2));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of CabbagePart2.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfCabbagePart2 CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfCabbagePart2 CustomAttributes)
    public class DetailArrayOfCabbagePart2 : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.DetailArrayOfCabbagePart2 members)

        // *** End programmer edit section *** (NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.DetailArrayOfCabbagePart2 members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type CabbagePart2 by index.
        /// </summary>
        /// <summary>
        /// Adds object with type CabbagePart2.
        /// </summary>
        public DetailArrayOfCabbagePart2(NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.Cabbage2 fCabbage2) : 
                base(typeof(CabbagePart2), ((ICSSoft.STORMNET.DataObject)(fCabbage2)))
        {
        }
        
        public NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.CabbagePart2 this[int index]
        {
            get
            {
                return ((NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.CabbagePart2)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(NewPlatform.Flexberry.ORM.ClickHouseDataService.Tests.CabbagePart2 dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
