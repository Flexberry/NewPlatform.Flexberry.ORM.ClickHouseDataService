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
    /// DetailClass.
    /// </summary>
    // *** Start programmer edit section *** (DetailClass CustomAttributes)

    // *** End programmer edit section *** (DetailClass CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("DetailClassE", new string[] {
            "Detailproperty"})]
    [View("DetailClassL", new string[] {
            "Detailproperty"})]
    [View("Test_DetailClassE", new string[] {
            "Detailproperty as \'Detail property\'",
            "DetailDateTimeProperty"})]
    public class DetailClass : ICSSoft.STORMNET.DataObject
    {
        
        private string fDetailproperty;
        
        private NewPlatform.ClickHouseDataService.Tests.MasterClass fMasterClass;
        
        // *** Start programmer edit section *** (DetailClass CustomMembers)

        // *** End programmer edit section *** (DetailClass CustomMembers)

        
        /// <summary>
        /// Detailproperty.
        /// </summary>
        // *** Start programmer edit section *** (DetailClass.Detailproperty CustomAttributes)

        // *** End programmer edit section *** (DetailClass.Detailproperty CustomAttributes)
        [StrLen(255)]
        public virtual string Detailproperty
        {
            get
            {
                // *** Start programmer edit section *** (DetailClass.Detailproperty Get start)

                // *** End programmer edit section *** (DetailClass.Detailproperty Get start)
                string result = this.fDetailproperty;
                // *** Start programmer edit section *** (DetailClass.Detailproperty Get end)

                // *** End programmer edit section *** (DetailClass.Detailproperty Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (DetailClass.Detailproperty Set start)

                // *** End programmer edit section *** (DetailClass.Detailproperty Set start)
                this.fDetailproperty = value;
                // *** Start programmer edit section *** (DetailClass.Detailproperty Set end)

                // *** End programmer edit section *** (DetailClass.Detailproperty Set end)
            }
        }
        
        /// <summary>
        /// DetailDateTimeProperty.
        /// </summary>
        // *** Start programmer edit section *** (DetailClass.DetailDateTimeProperty CustomAttributes)

        // *** End programmer edit section *** (DetailClass.DetailDateTimeProperty CustomAttributes)
        [ICSSoft.STORMNET.NotStored()]
        public virtual ICSSoft.STORMNET.UserDataTypes.NullableDateTime DetailDateTimeProperty
        {
            get
            {
                // *** Start programmer edit section *** (DetailClass.DetailDateTimeProperty Get)

                return null;
                // *** End programmer edit section *** (DetailClass.DetailDateTimeProperty Get)
            }
            set
            {
                // *** Start programmer edit section *** (DetailClass.DetailDateTimeProperty Set)

                // *** End programmer edit section *** (DetailClass.DetailDateTimeProperty Set)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку NewPlatform.ClickHouseDataService.Tests.MasterClass.
        /// </summary>
        // *** Start programmer edit section *** (DetailClass.MasterClass CustomAttributes)

        // *** End programmer edit section *** (DetailClass.MasterClass CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage("MasterClass")]
        [TypeUsage(new string[] {
                "NewPlatform.ClickHouseDataService.Tests.InheritedMasterClass",
                "NewPlatform.ClickHouseDataService.Tests.MasterClass"})]
        public virtual NewPlatform.ClickHouseDataService.Tests.MasterClass MasterClass
        {
            get
            {
                // *** Start programmer edit section *** (DetailClass.MasterClass Get start)

                // *** End programmer edit section *** (DetailClass.MasterClass Get start)
                NewPlatform.ClickHouseDataService.Tests.MasterClass result = this.fMasterClass;
                // *** Start programmer edit section *** (DetailClass.MasterClass Get end)

                // *** End programmer edit section *** (DetailClass.MasterClass Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (DetailClass.MasterClass Set start)

                // *** End programmer edit section *** (DetailClass.MasterClass Set start)
                this.fMasterClass = value;
                // *** Start programmer edit section *** (DetailClass.MasterClass Set end)

                // *** End programmer edit section *** (DetailClass.MasterClass Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "DetailClassE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View DetailClassE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("DetailClassE", typeof(NewPlatform.ClickHouseDataService.Tests.DetailClass));
                }
            }
            
            /// <summary>
            /// "DetailClassL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View DetailClassL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("DetailClassL", typeof(NewPlatform.ClickHouseDataService.Tests.DetailClass));
                }
            }
            
            /// <summary>
            /// "Test_DetailClassE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View Test_DetailClassE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("Test_DetailClassE", typeof(NewPlatform.ClickHouseDataService.Tests.DetailClass));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of DetailClass.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfDetailClass CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfDetailClass CustomAttributes)
    public class DetailArrayOfDetailClass : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (NewPlatform.ClickHouseDataService.Tests.DetailArrayOfDetailClass members)

        // *** End programmer edit section *** (NewPlatform.ClickHouseDataService.Tests.DetailArrayOfDetailClass members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type DetailClass by index.
        /// </summary>
        /// <summary>
        /// Adds object with type DetailClass.
        /// </summary>
        public DetailArrayOfDetailClass(NewPlatform.ClickHouseDataService.Tests.MasterClass fMasterClass) : 
                base(typeof(DetailClass), ((ICSSoft.STORMNET.DataObject)(fMasterClass)))
        {
        }
        
        public NewPlatform.ClickHouseDataService.Tests.DetailClass this[int index]
        {
            get
            {
                return ((NewPlatform.ClickHouseDataService.Tests.DetailClass)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(NewPlatform.ClickHouseDataService.Tests.DetailClass dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}