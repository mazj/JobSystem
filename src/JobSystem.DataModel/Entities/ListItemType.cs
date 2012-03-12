﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
		WorkLocationCompleted = 33,
		WorkLocationCalibrated = 34,
		WorkLocationRepaired = 35,
		WorkLocationSubContract = 36,
		WorkLocationQuoted = 37,
		WorkLocationInvestigated = 38,
		CurrencyGbp = 39,
		CurrencyUsd = 40,
		CurrencyEuro = 41,
		PaymentTerm30Days = 42,
		PaymentTermAsAgreed = 43,
		JobTypeField = 44,
		JobTypeService = 45,
		StatusBookedIn = 46,
		InitialWorkLocationHouseCalibration = 47,
		InitialWorkLocationUkasCalibration = 48,
		InitialWorkLocationRepair = 49,
		InitialWorkLocationSubContract = 50,
		InitialWorkLocationSite = 51,
		StatusItemWithSubContractor = 52,
		StatusAwaitingParts = 53
	}
}