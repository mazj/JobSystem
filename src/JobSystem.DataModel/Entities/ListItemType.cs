﻿
namespace JobSystem.DataModel.Entities
{
    public enum ListItemType
    {
        CategoryTemperature = 1,
        CategoryElectrical = 2,
        CategoryDensity = 3,
        CategoryMechanical = 4,
        CategorySubContract = 5,
        CategoryHire = 6,
        CategoryResale = 7,
        CategoryPressure = 8,
        CategoryField = 9,
        InitialStatusUkasCalibration = 10,
        InitialStatusHouseCalibration = 11,
        InitialStatusSubContract = 12,
        InitialStatusRepair = 13,
        WorkStatusCalibrated = 14,
        WorkStatusRepaired = 15,
        WorkStatusFailed = 16,
        WorkStatusInvestigated = 17,
        WorkStatusReturned = 18,
        WorkStatusCompleted = 19,
        WorkStatusReviewed =20,
        StatusQuotedPrepared = 21,
        StatusQuoteAccepted = 22,
        StatusQuoteRejected = 23,
        StatusConsigned = 24,
        StatusOrderReviewed = 25,
        StatusOrdered = 26,
        StatusDeliveryNoteProduced = 27,
        StatusInvoiced = 28,
        WorkTypeCalibration = 29,
        WorkTypeRepair = 30,
        WorkTypeInvestigation = 31,
        WorkTypeAdministration = 32,
        PaymentTerm30Days = 42,
        PaymentTermAsAgreed = 43,
        JobTypeField = 44,
        JobTypeService = 45,
        StatusBookedIn = 46,
        StatusItemWithSubContractor = 52,
        StatusAwaitingParts = 53,
        CertificateTypeHouse = 54,
        CertificateTypeUkas = 55,
        StatusPartsReceived = 56,
        StatusQuoted = 57
    }
}