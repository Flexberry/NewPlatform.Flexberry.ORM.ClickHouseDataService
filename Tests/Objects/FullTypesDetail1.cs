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
    /// FullTypesDetail1.
    /// </summary>
    // *** Start programmer edit section *** (FullTypesDetail1 CustomAttributes)

    // *** End programmer edit section *** (FullTypesDetail1 CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("FullDetailView", new string[] {
            "PoleInt",
            "PoleDateTime",
            "PoleString",
            "PoleFloat",
            "PoleDouble",
            "PoleDecimal",
            "PoleBool",
            "PoleNullableInt",
            "PoleNullableDecimal",
            "PoleNullableDateTime",
            "PoleNullInt",
            "PoleNullDateTime",
            "PoleNullFloat",
            "PoleNullDouble",
            "PoleNullDecimal",
            "PoleGuid",
            "PoleNullGuid",
            "PoleEnum",
            "PoleChar",
            "PoleNullChar"})]
    public class FullTypesDetail1 : ICSSoft.STORMNET.DataObject
    {
        
        private int fPoleInt;
        
        private System.DateTime fPoleDateTime = System.DateTime.Now;
        
        private string fPoleString;
        
        private float fPoleFloat;
        
        private double fPoleDouble;
        
        private decimal fPoleDecimal;
        
        private bool fPoleBool;
        
        private ICSSoft.STORMNET.UserDataTypes.NullableInt fPoleNullableInt;
        
        private ICSSoft.STORMNET.UserDataTypes.NullableDecimal fPoleNullableDecimal;
        
        private ICSSoft.STORMNET.UserDataTypes.NullableDateTime fPoleNullableDateTime;
        
        private System.Nullable<System.Int32> fPoleNullInt;
        
        private System.Nullable<System.DateTime> fPoleNullDateTime;
        
        private System.Nullable<System.Single> fPoleNullFloat;
        
        private System.Nullable<System.Double> fPoleNullDouble;
        
        private System.Nullable<System.Decimal> fPoleNullDecimal;
        
        private System.Guid fPoleGuid;
        
        private System.Nullable<System.Guid> fPoleNullGuid;
        
        private NewPlatform.ClickHouseDataService.Tests.PoleEnum fPoleEnum;
        
        private char fPoleChar;
        
        private System.Nullable<System.Char> fPoleNullChar;
        
        private NewPlatform.ClickHouseDataService.Tests.FullTypesMainAgregator fFullTypesMainAgregator;
        
        // *** Start programmer edit section *** (FullTypesDetail1 CustomMembers)

        // *** End programmer edit section *** (FullTypesDetail1 CustomMembers)

        
        /// <summary>
        /// PoleInt.
        /// </summary>
        // *** Start programmer edit section *** (FullTypesDetail1.PoleInt CustomAttributes)

        // *** End programmer edit section *** (FullTypesDetail1.PoleInt CustomAttributes)
        public virtual int PoleInt
        {
            get
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleInt Get start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleInt Get start)
                int result = this.fPoleInt;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleInt Get end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleInt Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleInt Set start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleInt Set start)
                this.fPoleInt = value;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleInt Set end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleInt Set end)
            }
        }
        
        /// <summary>
        /// PoleDateTime.
        /// </summary>
        // *** Start programmer edit section *** (FullTypesDetail1.PoleDateTime CustomAttributes)

        // *** End programmer edit section *** (FullTypesDetail1.PoleDateTime CustomAttributes)
        public virtual System.DateTime PoleDateTime
        {
            get
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleDateTime Get start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleDateTime Get start)
                System.DateTime result = this.fPoleDateTime;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleDateTime Get end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleDateTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleDateTime Set start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleDateTime Set start)
                this.fPoleDateTime = value;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleDateTime Set end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleDateTime Set end)
            }
        }
        
        /// <summary>
        /// PoleString.
        /// </summary>
        // *** Start programmer edit section *** (FullTypesDetail1.PoleString CustomAttributes)

        // *** End programmer edit section *** (FullTypesDetail1.PoleString CustomAttributes)
        [StrLen(255)]
        public virtual string PoleString
        {
            get
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleString Get start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleString Get start)
                string result = this.fPoleString;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleString Get end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleString Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleString Set start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleString Set start)
                this.fPoleString = value;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleString Set end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleString Set end)
            }
        }
        
        /// <summary>
        /// PoleFloat.
        /// </summary>
        // *** Start programmer edit section *** (FullTypesDetail1.PoleFloat CustomAttributes)

        // *** End programmer edit section *** (FullTypesDetail1.PoleFloat CustomAttributes)
        public virtual float PoleFloat
        {
            get
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleFloat Get start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleFloat Get start)
                float result = this.fPoleFloat;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleFloat Get end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleFloat Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleFloat Set start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleFloat Set start)
                this.fPoleFloat = value;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleFloat Set end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleFloat Set end)
            }
        }
        
        /// <summary>
        /// PoleDouble.
        /// </summary>
        // *** Start programmer edit section *** (FullTypesDetail1.PoleDouble CustomAttributes)

        // *** End programmer edit section *** (FullTypesDetail1.PoleDouble CustomAttributes)
        public virtual double PoleDouble
        {
            get
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleDouble Get start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleDouble Get start)
                double result = this.fPoleDouble;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleDouble Get end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleDouble Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleDouble Set start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleDouble Set start)
                this.fPoleDouble = value;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleDouble Set end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleDouble Set end)
            }
        }
        
        /// <summary>
        /// PoleDecimal.
        /// </summary>
        // *** Start programmer edit section *** (FullTypesDetail1.PoleDecimal CustomAttributes)

        // *** End programmer edit section *** (FullTypesDetail1.PoleDecimal CustomAttributes)
        public virtual decimal PoleDecimal
        {
            get
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleDecimal Get start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleDecimal Get start)
                decimal result = this.fPoleDecimal;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleDecimal Get end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleDecimal Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleDecimal Set start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleDecimal Set start)
                this.fPoleDecimal = value;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleDecimal Set end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleDecimal Set end)
            }
        }
        
        /// <summary>
        /// PoleBool.
        /// </summary>
        // *** Start programmer edit section *** (FullTypesDetail1.PoleBool CustomAttributes)

        // *** End programmer edit section *** (FullTypesDetail1.PoleBool CustomAttributes)
        public virtual bool PoleBool
        {
            get
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleBool Get start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleBool Get start)
                bool result = this.fPoleBool;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleBool Get end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleBool Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleBool Set start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleBool Set start)
                this.fPoleBool = value;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleBool Set end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleBool Set end)
            }
        }
        
        /// <summary>
        /// PoleNullableInt.
        /// </summary>
        // *** Start programmer edit section *** (FullTypesDetail1.PoleNullableInt CustomAttributes)

        // *** End programmer edit section *** (FullTypesDetail1.PoleNullableInt CustomAttributes)
        public virtual ICSSoft.STORMNET.UserDataTypes.NullableInt PoleNullableInt
        {
            get
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullableInt Get start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullableInt Get start)
                ICSSoft.STORMNET.UserDataTypes.NullableInt result = this.fPoleNullableInt;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullableInt Get end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullableInt Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullableInt Set start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullableInt Set start)
                this.fPoleNullableInt = value;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullableInt Set end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullableInt Set end)
            }
        }
        
        /// <summary>
        /// PoleNullableDecimal.
        /// </summary>
        // *** Start programmer edit section *** (FullTypesDetail1.PoleNullableDecimal CustomAttributes)

        // *** End programmer edit section *** (FullTypesDetail1.PoleNullableDecimal CustomAttributes)
        public virtual ICSSoft.STORMNET.UserDataTypes.NullableDecimal PoleNullableDecimal
        {
            get
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullableDecimal Get start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullableDecimal Get start)
                ICSSoft.STORMNET.UserDataTypes.NullableDecimal result = this.fPoleNullableDecimal;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullableDecimal Get end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullableDecimal Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullableDecimal Set start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullableDecimal Set start)
                this.fPoleNullableDecimal = value;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullableDecimal Set end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullableDecimal Set end)
            }
        }
        
        /// <summary>
        /// PoleNullableDateTime.
        /// </summary>
        // *** Start programmer edit section *** (FullTypesDetail1.PoleNullableDateTime CustomAttributes)

        // *** End programmer edit section *** (FullTypesDetail1.PoleNullableDateTime CustomAttributes)
        public virtual ICSSoft.STORMNET.UserDataTypes.NullableDateTime PoleNullableDateTime
        {
            get
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullableDateTime Get start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullableDateTime Get start)
                ICSSoft.STORMNET.UserDataTypes.NullableDateTime result = this.fPoleNullableDateTime;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullableDateTime Get end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullableDateTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullableDateTime Set start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullableDateTime Set start)
                this.fPoleNullableDateTime = value;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullableDateTime Set end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullableDateTime Set end)
            }
        }
        
        /// <summary>
        /// PoleNullInt.
        /// </summary>
        // *** Start programmer edit section *** (FullTypesDetail1.PoleNullInt CustomAttributes)

        // *** End programmer edit section *** (FullTypesDetail1.PoleNullInt CustomAttributes)
        public virtual System.Nullable<System.Int32> PoleNullInt
        {
            get
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullInt Get start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullInt Get start)
                System.Nullable<System.Int32> result = this.fPoleNullInt;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullInt Get end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullInt Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullInt Set start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullInt Set start)
                this.fPoleNullInt = value;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullInt Set end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullInt Set end)
            }
        }
        
        /// <summary>
        /// PoleNullDateTime.
        /// </summary>
        // *** Start programmer edit section *** (FullTypesDetail1.PoleNullDateTime CustomAttributes)

        // *** End programmer edit section *** (FullTypesDetail1.PoleNullDateTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> PoleNullDateTime
        {
            get
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullDateTime Get start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullDateTime Get start)
                System.Nullable<System.DateTime> result = this.fPoleNullDateTime;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullDateTime Get end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullDateTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullDateTime Set start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullDateTime Set start)
                this.fPoleNullDateTime = value;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullDateTime Set end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullDateTime Set end)
            }
        }
        
        /// <summary>
        /// PoleNullFloat.
        /// </summary>
        // *** Start programmer edit section *** (FullTypesDetail1.PoleNullFloat CustomAttributes)

        // *** End programmer edit section *** (FullTypesDetail1.PoleNullFloat CustomAttributes)
        public virtual System.Nullable<System.Single> PoleNullFloat
        {
            get
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullFloat Get start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullFloat Get start)
                System.Nullable<System.Single> result = this.fPoleNullFloat;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullFloat Get end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullFloat Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullFloat Set start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullFloat Set start)
                this.fPoleNullFloat = value;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullFloat Set end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullFloat Set end)
            }
        }
        
        /// <summary>
        /// PoleNullDouble.
        /// </summary>
        // *** Start programmer edit section *** (FullTypesDetail1.PoleNullDouble CustomAttributes)

        // *** End programmer edit section *** (FullTypesDetail1.PoleNullDouble CustomAttributes)
        public virtual System.Nullable<System.Double> PoleNullDouble
        {
            get
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullDouble Get start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullDouble Get start)
                System.Nullable<System.Double> result = this.fPoleNullDouble;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullDouble Get end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullDouble Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullDouble Set start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullDouble Set start)
                this.fPoleNullDouble = value;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullDouble Set end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullDouble Set end)
            }
        }
        
        /// <summary>
        /// PoleNullDecimal.
        /// </summary>
        // *** Start programmer edit section *** (FullTypesDetail1.PoleNullDecimal CustomAttributes)

        // *** End programmer edit section *** (FullTypesDetail1.PoleNullDecimal CustomAttributes)
        public virtual System.Nullable<System.Decimal> PoleNullDecimal
        {
            get
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullDecimal Get start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullDecimal Get start)
                System.Nullable<System.Decimal> result = this.fPoleNullDecimal;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullDecimal Get end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullDecimal Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullDecimal Set start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullDecimal Set start)
                this.fPoleNullDecimal = value;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullDecimal Set end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullDecimal Set end)
            }
        }
        
        /// <summary>
        /// PoleGuid.
        /// </summary>
        // *** Start programmer edit section *** (FullTypesDetail1.PoleGuid CustomAttributes)

        // *** End programmer edit section *** (FullTypesDetail1.PoleGuid CustomAttributes)
        public virtual System.Guid PoleGuid
        {
            get
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleGuid Get start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleGuid Get start)
                System.Guid result = this.fPoleGuid;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleGuid Get end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleGuid Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleGuid Set start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleGuid Set start)
                this.fPoleGuid = value;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleGuid Set end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleGuid Set end)
            }
        }
        
        /// <summary>
        /// PoleNullGuid.
        /// </summary>
        // *** Start programmer edit section *** (FullTypesDetail1.PoleNullGuid CustomAttributes)

        // *** End programmer edit section *** (FullTypesDetail1.PoleNullGuid CustomAttributes)
        public virtual System.Nullable<System.Guid> PoleNullGuid
        {
            get
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullGuid Get start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullGuid Get start)
                System.Nullable<System.Guid> result = this.fPoleNullGuid;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullGuid Get end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullGuid Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullGuid Set start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullGuid Set start)
                this.fPoleNullGuid = value;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullGuid Set end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullGuid Set end)
            }
        }
        
        /// <summary>
        /// PoleEnum.
        /// </summary>
        // *** Start programmer edit section *** (FullTypesDetail1.PoleEnum CustomAttributes)

        // *** End programmer edit section *** (FullTypesDetail1.PoleEnum CustomAttributes)
        public virtual NewPlatform.ClickHouseDataService.Tests.PoleEnum PoleEnum
        {
            get
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleEnum Get start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleEnum Get start)
                NewPlatform.ClickHouseDataService.Tests.PoleEnum result = this.fPoleEnum;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleEnum Get end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleEnum Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleEnum Set start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleEnum Set start)
                this.fPoleEnum = value;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleEnum Set end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleEnum Set end)
            }
        }
        
        /// <summary>
        /// PoleChar.
        /// </summary>
        // *** Start programmer edit section *** (FullTypesDetail1.PoleChar CustomAttributes)

        // *** End programmer edit section *** (FullTypesDetail1.PoleChar CustomAttributes)
        public virtual char PoleChar
        {
            get
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleChar Get start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleChar Get start)
                char result = this.fPoleChar;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleChar Get end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleChar Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleChar Set start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleChar Set start)
                this.fPoleChar = value;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleChar Set end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleChar Set end)
            }
        }
        
        /// <summary>
        /// PoleNullChar.
        /// </summary>
        // *** Start programmer edit section *** (FullTypesDetail1.PoleNullChar CustomAttributes)

        // *** End programmer edit section *** (FullTypesDetail1.PoleNullChar CustomAttributes)
        public virtual System.Nullable<System.Char> PoleNullChar
        {
            get
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullChar Get start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullChar Get start)
                System.Nullable<System.Char> result = this.fPoleNullChar;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullChar Get end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullChar Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullChar Set start)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullChar Set start)
                this.fPoleNullChar = value;
                // *** Start programmer edit section *** (FullTypesDetail1.PoleNullChar Set end)

                // *** End programmer edit section *** (FullTypesDetail1.PoleNullChar Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку NewPlatform.ClickHouseDataService.Tests.FullTypesMainAgregator.
        /// </summary>
        // *** Start programmer edit section *** (FullTypesDetail1.FullTypesMainAgregator CustomAttributes)

        // *** End programmer edit section *** (FullTypesDetail1.FullTypesMainAgregator CustomAttributes)
        [Agregator()]
        [NotNull()]
        public virtual NewPlatform.ClickHouseDataService.Tests.FullTypesMainAgregator FullTypesMainAgregator
        {
            get
            {
                // *** Start programmer edit section *** (FullTypesDetail1.FullTypesMainAgregator Get start)

                // *** End programmer edit section *** (FullTypesDetail1.FullTypesMainAgregator Get start)
                NewPlatform.ClickHouseDataService.Tests.FullTypesMainAgregator result = this.fFullTypesMainAgregator;
                // *** Start programmer edit section *** (FullTypesDetail1.FullTypesMainAgregator Get end)

                // *** End programmer edit section *** (FullTypesDetail1.FullTypesMainAgregator Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (FullTypesDetail1.FullTypesMainAgregator Set start)

                // *** End programmer edit section *** (FullTypesDetail1.FullTypesMainAgregator Set start)
                this.fFullTypesMainAgregator = value;
                // *** Start programmer edit section *** (FullTypesDetail1.FullTypesMainAgregator Set end)

                // *** End programmer edit section *** (FullTypesDetail1.FullTypesMainAgregator Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "FullDetailView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View FullDetailView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("FullDetailView", typeof(NewPlatform.ClickHouseDataService.Tests.FullTypesDetail1));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of FullTypesDetail1.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfFullTypesDetail1 CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfFullTypesDetail1 CustomAttributes)
    public class DetailArrayOfFullTypesDetail1 : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (NewPlatform.ClickHouseDataService.Tests.DetailArrayOfFullTypesDetail1 members)

        // *** End programmer edit section *** (NewPlatform.ClickHouseDataService.Tests.DetailArrayOfFullTypesDetail1 members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type FullTypesDetail1 by index.
        /// </summary>
        /// <summary>
        /// Adds object with type FullTypesDetail1.
        /// </summary>
        public DetailArrayOfFullTypesDetail1(NewPlatform.ClickHouseDataService.Tests.FullTypesMainAgregator fFullTypesMainAgregator) : 
                base(typeof(FullTypesDetail1), ((ICSSoft.STORMNET.DataObject)(fFullTypesMainAgregator)))
        {
        }
        
        public NewPlatform.ClickHouseDataService.Tests.FullTypesDetail1 this[int index]
        {
            get
            {
                return ((NewPlatform.ClickHouseDataService.Tests.FullTypesDetail1)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(NewPlatform.ClickHouseDataService.Tests.FullTypesDetail1 dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
