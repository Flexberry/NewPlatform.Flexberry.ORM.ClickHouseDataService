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
    /// Region.
    /// </summary>
    // *** Start programmer edit section *** (Region CustomAttributes)

    // *** End programmer edit section *** (Region CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("RegionE", new string[] {
            "RegionName as \'Region name\'"})]
    public class Region : ICSSoft.STORMNET.DataObject
    {
        
        private string fRegionName;
        
        private NewPlatform.ClickHouseDataService.Tests.Country2 fCountry2;
        
        // *** Start programmer edit section *** (Region CustomMembers)

        // *** End programmer edit section *** (Region CustomMembers)

        
        /// <summary>
        /// RegionName.
        /// </summary>
        // *** Start programmer edit section *** (Region.RegionName CustomAttributes)

        // *** End programmer edit section *** (Region.RegionName CustomAttributes)
        [StrLen(255)]
        public virtual string RegionName
        {
            get
            {
                // *** Start programmer edit section *** (Region.RegionName Get start)

                // *** End programmer edit section *** (Region.RegionName Get start)
                string result = this.fRegionName;
                // *** Start programmer edit section *** (Region.RegionName Get end)

                // *** End programmer edit section *** (Region.RegionName Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Region.RegionName Set start)

                // *** End programmer edit section *** (Region.RegionName Set start)
                this.fRegionName = value;
                // *** Start programmer edit section *** (Region.RegionName Set end)

                // *** End programmer edit section *** (Region.RegionName Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку NewPlatform.ClickHouseDataService.Tests.Country2.
        /// </summary>
        // *** Start programmer edit section *** (Region.Country2 CustomAttributes)

        // *** End programmer edit section *** (Region.Country2 CustomAttributes)
        [Agregator()]
        [NotNull()]
        public virtual NewPlatform.ClickHouseDataService.Tests.Country2 Country2
        {
            get
            {
                // *** Start programmer edit section *** (Region.Country2 Get start)

                // *** End programmer edit section *** (Region.Country2 Get start)
                NewPlatform.ClickHouseDataService.Tests.Country2 result = this.fCountry2;
                // *** Start programmer edit section *** (Region.Country2 Get end)

                // *** End programmer edit section *** (Region.Country2 Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Region.Country2 Set start)

                // *** End programmer edit section *** (Region.Country2 Set start)
                this.fCountry2 = value;
                // *** Start programmer edit section *** (Region.Country2 Set end)

                // *** End programmer edit section *** (Region.Country2 Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "RegionE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View RegionE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("RegionE", typeof(NewPlatform.ClickHouseDataService.Tests.Region));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of Region.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfRegion CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfRegion CustomAttributes)
    public class DetailArrayOfRegion : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (NewPlatform.ClickHouseDataService.Tests.DetailArrayOfRegion members)

        // *** End programmer edit section *** (NewPlatform.ClickHouseDataService.Tests.DetailArrayOfRegion members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type Region by index.
        /// </summary>
        /// <summary>
        /// Adds object with type Region.
        /// </summary>
        public DetailArrayOfRegion(NewPlatform.ClickHouseDataService.Tests.Country2 fCountry2) : 
                base(typeof(Region), ((ICSSoft.STORMNET.DataObject)(fCountry2)))
        {
        }
        
        public NewPlatform.ClickHouseDataService.Tests.Region this[int index]
        {
            get
            {
                return ((NewPlatform.ClickHouseDataService.Tests.Region)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(NewPlatform.ClickHouseDataService.Tests.Region dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}