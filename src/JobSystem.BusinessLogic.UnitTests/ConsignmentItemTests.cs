﻿using System;
using JobSystem.BusinessLogic.Services;
using JobSystem.BusinessLogic.Validation.Core;
using JobSystem.DataModel;
using JobSystem.DataModel.Entities;
using JobSystem.DataModel.Repositories;
using JobSystem.Resources.Consignments;
using JobSystem.TestHelpers;
using JobSystem.TestHelpers.Context;
using NUnit.Framework;
using Rhino.Mocks;

namespace JobSystem.BusinessLogic.UnitTests
{
    [TestFixture]
    public class ConsignmentItemTests
    {
        private ConsignmentItemService _consignmentItemService;
        private JobItemService _jobItemService;
        private DomainValidationException _domainValidationException;
        private ConsignmentItem _savedConsigmentItem;
        private PendingConsignmentItem _savedPendingItem;
        private JobItem _jobItemToUpdate;
        private IUserContext _userContext;

        private Guid _jobItemforEditPendingId;
        private JobItem _jobItemForEditPending;
        private Guid _pendingItemId;
        private PendingConsignmentItem _pendingItemForEdit;

        private Guid _consignmentItemForEditId;
        private ConsignmentItem _consignmentItemForEdit;

        [TestFixtureSetUp]
        public void FixtureSetup()
        {
            _userContext = TestUserContext.Create("graham.robertson@intertek.com", "Graham Robertson", "Operations Manager", UserRole.Member);
        }

        [SetUp]
        public void Setup()
        {
            _domainValidationException = null;
            _jobItemToUpdate = new JobItem
            {
                Id = Guid.NewGuid(),
                Job = new Job
                {
                    Id = Guid.NewGuid(),
                    JobNo = "JR2000",
                    CreatedBy = _userContext.GetCurrentUser(),
                    OrderNo = "ORDER12345",
                    DateCreated = DateTime.UtcNow,
                    Customer = new Customer { Id = Guid.NewGuid(), Name = "Gael Ltd" }
                },
                ItemNo = 1,
                SerialNo = "12345",
                Instrument = new Instrument
                {
                    Id = Guid.NewGuid(), Manufacturer = "Druck", ModelNo = "DPI601IS", Range = "None", Description = "Digital Pressure Indicator"
                },
                CalPeriod = 12,
                Created = DateTime.UtcNow,
                CreatedUser = _userContext.GetCurrentUser(),
            };
            _jobItemforEditPendingId = Guid.NewGuid();
            _jobItemForEditPending = new JobItem
            {
                Id = _jobItemforEditPendingId,
                Job = new Job
                {
                    Id = Guid.NewGuid(),
                    JobNo = "JR2001",
                    CreatedBy = _userContext.GetCurrentUser(),
                    OrderNo = "ORDER12345",
                    DateCreated = DateTime.UtcNow,
                    Customer = new Customer { Id = Guid.NewGuid(), Name = "Gael Ltd" }
                },
                ItemNo = 1,
                SerialNo = "12345",
                Instrument = new Instrument
                {
                    Id = Guid.NewGuid(),
                    Manufacturer = "Druck",
                    ModelNo = "DPI601IS",
                    Range = "None",
                    Description = "Digital Pressure Indicator"
                },
                CalPeriod = 12,
                Created = DateTime.UtcNow,
                CreatedUser = _userContext.GetCurrentUser(),
            };
            _pendingItemId = Guid.NewGuid();
            _pendingItemForEdit = new PendingConsignmentItem
            {
                Id = _pendingItemId,
                Supplier = new Supplier { Id = Guid.NewGuid(), Name = "Gael Ltd" },
                JobItem = _jobItemForEditPending,
                Instructions = "some instructions"
            };
            _consignmentItemForEditId = Guid.NewGuid();
            _consignmentItemForEdit = new ConsignmentItem
            {
                Id = _consignmentItemForEditId,
                ItemNo = 1,
                Instructions = "some instructions",
                Consignment = new Consignment
                {
                    Id = Guid.NewGuid(),
                    ConsignmentNo = "CR2000",
                    IsOrdered = false
                }
            };
        }

        #region Create

        [Test]
        public void Create_ValidDetailsSuppliedConsignmentHas0Items_SuccessfullyCreated()
        {
            var id = Guid.NewGuid();
            var consignmentId = Guid.NewGuid();
            var instructions = "Consignment instructions";

            var consignmentItemRepositoryMock = MockRepository.GenerateMock<IConsignmentItemRepository>();
            consignmentItemRepositoryMock.Expect(x => x.Create(null)).IgnoreArguments();
            var jobItemRepositoryMock = MockRepository.GenerateMock<IJobItemRepository>();
            jobItemRepositoryMock.Stub(x => x.GetById(_jobItemToUpdate.Id)).Return(_jobItemToUpdate);
            jobItemRepositoryMock.Expect(x => x.EmitItemHistory(
                _userContext.GetCurrentUser(), _jobItemToUpdate.Id, 0, 0, "Item consigned on CR2000", ListItemType.StatusConsigned, ListItemType.WorkTypeAdministration));
            jobItemRepositoryMock.Expect(x => x.Update(_jobItemToUpdate)).IgnoreArguments();

            _consignmentItemService = ConsignmentItemServiceFactory.Create(consignmentItemRepositoryMock, jobItemRepositoryMock, consignmentId, _userContext);
            _jobItemService = _jobItemService = JobItemServiceFactory.CreateToReturnJobItem(jobItemRepositoryMock, _userContext);
            CreateConsignmentItem(id, _jobItemToUpdate.Id, consignmentId, instructions);
            consignmentItemRepositoryMock.VerifyAllExpectations();
            jobItemRepositoryMock.VerifyAllExpectations();
            Assert.AreNotEqual(Guid.Empty, _savedConsigmentItem.Id);
            Assert.AreEqual(1, _savedConsigmentItem.ItemNo);
            Assert.AreEqual(ListItemType.StatusConsigned, _jobItemToUpdate.Status.Type);
        }

        [Test]
        public void Create_ValidDetailsSuppliedConsignmentHas1Items_SuccessfullyCreated()
        {
            var id = Guid.NewGuid();
            var consignmentId = Guid.NewGuid();
            var instructions = "Consignment instructions";

            var consignmentItemRepositoryMock = MockRepository.GenerateMock<IConsignmentItemRepository>();
            consignmentItemRepositoryMock.Expect(x => x.Create(null)).IgnoreArguments();
            var jobItemRepositoryMock = MockRepository.GenerateMock<IJobItemRepository>();
            jobItemRepositoryMock.Stub(x => x.GetById(_jobItemToUpdate.Id)).Return(_jobItemToUpdate);
            jobItemRepositoryMock.Expect(x => x.EmitItemHistory(
                _userContext.GetCurrentUser(), _jobItemToUpdate.Id, 0, 0, "Item consigned on CR2000", ListItemType.StatusConsigned, ListItemType.WorkTypeAdministration));
            jobItemRepositoryMock.Expect(x => x.Update(_jobItemToUpdate)).IgnoreArguments();

            _consignmentItemService = ConsignmentItemServiceFactory.Create(consignmentItemRepositoryMock, jobItemRepositoryMock, consignmentId, _userContext, 1);
            _jobItemService = _jobItemService = JobItemServiceFactory.CreateToReturnJobItem(jobItemRepositoryMock, _userContext);
            CreateConsignmentItem(id, _jobItemToUpdate.Id, consignmentId, instructions);
            consignmentItemRepositoryMock.VerifyAllExpectations();
            jobItemRepositoryMock.VerifyAllExpectations();
            Assert.AreNotEqual(Guid.Empty, _savedConsigmentItem.Id);
            Assert.AreEqual(2, _savedConsigmentItem.ItemNo);
            Assert.AreEqual(ListItemType.StatusConsigned, _jobItemToUpdate.Status.Type);
        }

        [Test]
        public void Create_JobIsPending_DomainValidationExceptionThrown()
        {
            var id = Guid.NewGuid();
            var consignmentId = Guid.NewGuid();
            var instructions = "Consignment instructions";

            _jobItemToUpdate.Job.IsPending = true;
            var jobItemRepositoryStub = MockRepository.GenerateMock<IJobItemRepository>();
            jobItemRepositoryStub.Stub(x => x.GetById(_jobItemToUpdate.Id)).Return(_jobItemToUpdate);

            _consignmentItemService = ConsignmentItemServiceFactory.Create(MockRepository.GenerateStub<IConsignmentItemRepository>(), jobItemRepositoryStub, consignmentId, _userContext);
            _jobItemService = _jobItemService = JobItemServiceFactory.CreateToReturnJobItem(jobItemRepositoryStub, _userContext);
            CreateConsignmentItem(id, _jobItemToUpdate.Id, consignmentId, instructions);
            Assert.IsTrue(_domainValidationException.ResultContainsMessage(Messages.PendingJob));
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Create_NoIdSupplied_ArgumentExceptionThrown()
        {
            var id = Guid.Empty;
            var consignmentId = Guid.NewGuid();
            var instructions = "Consignment instructions";

            _jobItemToUpdate.Job.IsPending = true;
            var jobItemRepositoryStub = MockRepository.GenerateMock<IJobItemRepository>();
            jobItemRepositoryStub.Stub(x => x.GetById(_jobItemToUpdate.Id)).Return(_jobItemToUpdate);

            _consignmentItemService = ConsignmentItemServiceFactory.Create(MockRepository.GenerateStub<IConsignmentItemRepository>(), jobItemRepositoryStub, consignmentId, _userContext);
            _jobItemService = _jobItemService = JobItemServiceFactory.CreateToReturnJobItem(jobItemRepositoryStub, _userContext);
            CreateConsignmentItem(id, _jobItemToUpdate.Id, consignmentId, instructions);
            Assert.IsTrue(_domainValidationException.ResultContainsMessage(Messages.PendingJob));
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Create_InvalidConsignmentIdSupplied_ArgumentExceptionThrown()
        {
            var id = Guid.NewGuid();
            var consignmentId = Guid.Empty;
            var instructions = "Consignment instructions";

            var jobItemRepositoryMock = MockRepository.GenerateMock<IJobItemRepository>();
            jobItemRepositoryMock.Stub(x => x.GetById(_jobItemToUpdate.Id)).Return(_jobItemToUpdate);

            _consignmentItemService = ConsignmentItemServiceFactory.Create(MockRepository.GenerateStub<IConsignmentItemRepository>(), jobItemRepositoryMock, consignmentId, _userContext);
            _jobItemService = _jobItemService = JobItemServiceFactory.CreateToReturnJobItem(jobItemRepositoryMock, _userContext);
            CreateConsignmentItem(id, _jobItemToUpdate.Id, consignmentId, instructions);
        }

        [Test]
        public void Create_InstructionsGreaterThan10000Characters_DomainValidationExceptionThrown()
        {
            var id = Guid.NewGuid();
            var consignmentId = Guid.NewGuid();
            var instructions = new string('a', 10001);

            var jobItemRepositoryMock = MockRepository.GenerateMock<IJobItemRepository>();
            jobItemRepositoryMock.Stub(x => x.GetById(_jobItemToUpdate.Id)).Return(_jobItemToUpdate);

            _consignmentItemService = ConsignmentItemServiceFactory.Create(MockRepository.GenerateStub<IConsignmentItemRepository>(), jobItemRepositoryMock, consignmentId, _userContext);
            _jobItemService = _jobItemService = JobItemServiceFactory.CreateToReturnJobItem(jobItemRepositoryMock, _userContext);
            CreateConsignmentItem(id, _jobItemToUpdate.Id, consignmentId, instructions);
            Assert.IsTrue(_domainValidationException.ResultContainsMessage(Messages.InstructionsTooLarge));
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Create_InvalidJobItemIdSupplied_ArgumentExceptionThrown()
        {
            var id = Guid.NewGuid();
            var consignmentId = Guid.NewGuid();
            var instructions = "Consignment instructions";

            var jobItemRepositoryMock = MockRepository.GenerateMock<IJobItemRepository>();
            jobItemRepositoryMock.Stub(x => x.GetById(Guid.NewGuid())).Return(null);

            _consignmentItemService = ConsignmentItemServiceFactory.Create(MockRepository.GenerateStub<IConsignmentItemRepository>(), jobItemRepositoryMock, consignmentId, _userContext);
            _jobItemService = _jobItemService = JobItemServiceFactory.CreateToReturnJobItem(jobItemRepositoryMock, _userContext);
            CreateConsignmentItem(id, _jobItemToUpdate.Id, consignmentId, instructions);
        }

        [Test]
        public void Create_UserHasInsufficientSecurityClearance_ArgumentExceptionThrown()
        {
            var id = Guid.NewGuid();
            var consignmentId = Guid.NewGuid();
            var instructions = "Consignment instructions";

            var jobItemRepositoryMock = MockRepository.GenerateMock<IJobItemRepository>();
            jobItemRepositoryMock.Stub(x => x.GetById(Guid.NewGuid())).Return(null);

            _consignmentItemService = ConsignmentItemServiceFactory.Create(
                MockRepository.GenerateStub<IConsignmentItemRepository>(), jobItemRepositoryMock, consignmentId,
                TestUserContext.Create("graham.robertson@intertek.com", "Graham Robertson", "Operations Manager", UserRole.Public));
            _jobItemService = _jobItemService = JobItemServiceFactory.CreateToReturnJobItem(jobItemRepositoryMock,
                TestUserContext.Create("graham.robertson@intertek.com", "Graham Robertson", "Operations Manager", UserRole.Public));
            CreateConsignmentItem(id, _jobItemToUpdate.Id, consignmentId, instructions);
            Assert.IsTrue(_domainValidationException.ResultContainsMessage(Messages.InsufficientSecurityClearance));
        }

        private void CreateConsignmentItem(Guid id, Guid jobItemId, Guid consignmentId, string instructions)
        {
            try
            {
                _savedConsigmentItem = _consignmentItemService.Create(id, jobItemId, consignmentId, instructions);
                _jobItemToUpdate = _jobItemService.GetById(_jobItemToUpdate.Id);
            }
            catch (DomainValidationException dex)
            {
                _domainValidationException = dex;
            }
        }

        #endregion
        #region CreatePending

        [Test]
        public void CreatePending_ValidPendingItemDetails_PendingItemCreated()
        {
            var id = Guid.NewGuid();
            var jobItemId = Guid.NewGuid();
            var supplierId = Guid.NewGuid();
            var instructions = "Please consign this item";

            var consignmentItemRepositoryMock = MockRepository.GenerateMock<IConsignmentItemRepository>();
            consignmentItemRepositoryMock.Expect(x => x.CreatePendingItem(null)).IgnoreArguments();
            _consignmentItemService = ConsignmentItemServiceFactory.CreateForPendingItems(consignmentItemRepositoryMock, jobItemId, supplierId, _userContext);
            CreatePendingConsignmentItem(id, jobItemId, supplierId, instructions);
            consignmentItemRepositoryMock.VerifyAllExpectations();
            Assert.AreNotEqual(Guid.Empty, _savedPendingItem.Id);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void CreatePending_InvalidJobItemId_ArgumentExceptionThrown()
        {
            var id = Guid.NewGuid();
            var jobItemId = Guid.Empty;
            var supplierId = Guid.NewGuid();
            var instructions = "Please consign this item";

            _consignmentItemService = ConsignmentItemServiceFactory.CreateForPendingItems(jobItemId, supplierId, _userContext);
            CreatePendingConsignmentItem(id, jobItemId, supplierId, instructions);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void CreatePending_InvalidSupplierId_ArgumentExceptionThrown()
        {
            var id = Guid.NewGuid();
            var jobItemId = Guid.NewGuid();
            var supplierId = Guid.Empty;
            var instructions = "Please consign this item";

            _consignmentItemService = ConsignmentItemServiceFactory.CreateForPendingItems(jobItemId, supplierId, _userContext);
            CreatePendingConsignmentItem(id, jobItemId, supplierId, instructions);
        }

        [Test]
        public void CreatePending_JobIsInPendingState_DomainValidationExceptionThrown()
        {
            var id = Guid.NewGuid();
            var jobItemId = Guid.NewGuid();
            var supplierId = Guid.NewGuid();
            var instructions = "Please consign this item";

            _consignmentItemService = ConsignmentItemServiceFactory.CreateForPendingItems(jobItemId, supplierId, _userContext, true);
            CreatePendingConsignmentItem(id, jobItemId, supplierId, instructions);
            Assert.IsTrue(_domainValidationException.ResultContainsMessage(Messages.PendingJob));
        }

        [Test]
        public void CreatePending_InstructionsGreaterThan10000Characters_DomainValidationExceptionThrown()
        {
            var id = Guid.NewGuid();
            var jobItemId = Guid.NewGuid();
            var supplierId = Guid.NewGuid();
            var instructions = new string('a', 10001);

            _consignmentItemService = ConsignmentItemServiceFactory.CreateForPendingItems(jobItemId, supplierId, _userContext);
            CreatePendingConsignmentItem(id, jobItemId, supplierId, instructions);
            Assert.IsTrue(_domainValidationException.ResultContainsMessage(Messages.InstructionsTooLarge));
        }

        [Test]
        public void CreatePending_UserHasInsufficientSecurityClearance_DomainValidationExceptionThrown()
        {
            var id = Guid.NewGuid();
            var jobItemId = Guid.NewGuid();
            var supplierId = Guid.NewGuid();
            var instructions = "Please consign this item";

            _consignmentItemService = ConsignmentItemServiceFactory.CreateForPendingItems(jobItemId, supplierId,
                 TestUserContext.Create("graham.robertson@intertek.com", "Graham Robertson", "Operations Manager", UserRole.Public));
            CreatePendingConsignmentItem(id, jobItemId, supplierId, instructions);
            Assert.IsTrue(_domainValidationException.ResultContainsMessage(Messages.InsufficientSecurityClearance));
        }

        [Test]
        public void CreatePending_JobItemAlreadyHasPendingItem_DomainValidationExceptionThrown()
        {
            var id = Guid.NewGuid();
            var jobItemId = Guid.NewGuid();
            var supplierId = Guid.NewGuid();
            var instructions = "Please consign this item";

            var consignmentItemRepositoryMock = MockRepository.GenerateStub<IConsignmentItemRepository>();
            consignmentItemRepositoryMock.Stub(x => x.JobItemHasPendingConsignmentItem(jobItemId)).Return(true);
            _consignmentItemService = ConsignmentItemServiceFactory.CreateForPendingItems(consignmentItemRepositoryMock, jobItemId, supplierId, _userContext);
            CreatePendingConsignmentItem(id, jobItemId, supplierId, instructions);
            Assert.IsTrue(_domainValidationException.ResultContainsMessage(Messages.PendingItemAlreadyExists));
        }

        private void CreatePendingConsignmentItem(Guid id, Guid jobItemId, Guid supplierId, string instructions)
        {
            try
            {
                _savedPendingItem = _consignmentItemService.CreatePending(id, jobItemId, supplierId, instructions);
            }
            catch (DomainValidationException dex)
            {
                _domainValidationException = dex;
            }
        }

        #endregion
        #region EditPending

        [Test]
        public void EditPending_ValidDetails_ItemEdited()
        {
            var supplierId = Guid.NewGuid();
            var instructions = "some edited instructions";

            var consignmentItemRepositoryMock = MockRepository.GenerateMock<IConsignmentItemRepository>();
            consignmentItemRepositoryMock.Stub(x => x.GetPendingItem(_pendingItemId)).Return(_pendingItemForEdit);
            consignmentItemRepositoryMock.Expect(x => x.UpdatePendingItem(null)).IgnoreArguments();
            _consignmentItemService = ConsignmentItemServiceFactory.CreateForEditForPendingItems(consignmentItemRepositoryMock, _jobItemforEditPendingId, supplierId, _userContext);
            EditPendingConsignmentItem(_pendingItemId, _jobItemforEditPendingId, supplierId, instructions);
            consignmentItemRepositoryMock.VerifyAllExpectations();
            Assert.AreEqual(instructions, _pendingItemForEdit.Instructions);
            Assert.AreEqual(supplierId, _pendingItemForEdit.Supplier.Id);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void EditPending_InvalidPendingItemId_ArgumentException()
        {
            var id = Guid.NewGuid();
            var supplierId = Guid.NewGuid();
            var instructions = "some edited instructions";

            var consignmentItemRepositoryStub = MockRepository.GenerateMock<IConsignmentItemRepository>();
            consignmentItemRepositoryStub.Stub(x => x.GetPendingItem(id)).Return(null);
            _consignmentItemService = ConsignmentItemServiceFactory.CreateForEditForPendingItems(consignmentItemRepositoryStub, _jobItemforEditPendingId, supplierId, _userContext);
            EditPendingConsignmentItem(_pendingItemId, _jobItemforEditPendingId, supplierId, instructions);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void EditPending_InvalidJobItemId_ArgumentException()
        {
            var supplierId = Guid.NewGuid();
            var instructions = "some edited instructions";

            var consignmentItemRepositoryStub = MockRepository.GenerateMock<IConsignmentItemRepository>();
            consignmentItemRepositoryStub.Stub(x => x.GetPendingItem(_pendingItemId)).Return(_pendingItemForEdit);
            _consignmentItemService = ConsignmentItemServiceFactory.CreateForEditForPendingItems(consignmentItemRepositoryStub, Guid.Empty, supplierId, _userContext);
            EditPendingConsignmentItem(_pendingItemId, _jobItemforEditPendingId, supplierId, instructions);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void EditPending_InvalidSupplierId_ArgumentException()
        {
            var supplierId = Guid.Empty;
            var instructions = "some edited instructions";

            var consignmentItemRepositoryStub = MockRepository.GenerateMock<IConsignmentItemRepository>();
            consignmentItemRepositoryStub.Stub(x => x.GetPendingItem(_pendingItemId)).Return(_pendingItemForEdit);
            _consignmentItemService = ConsignmentItemServiceFactory.CreateForEditForPendingItems(consignmentItemRepositoryStub, _jobItemforEditPendingId, supplierId, _userContext);
            EditPendingConsignmentItem(_pendingItemId, _jobItemforEditPendingId, supplierId, instructions);
        }

        [Test]
        public void EditPending_InvalidInstructions_DomainValidationException()
        {
            var supplierId = Guid.NewGuid();
            var instructions = new string('a', 10001);

            var consignmentItemRepositoryStub = MockRepository.GenerateMock<IConsignmentItemRepository>();
            consignmentItemRepositoryStub.Stub(x => x.GetPendingItem(_pendingItemId)).Return(_pendingItemForEdit);
            _consignmentItemService = ConsignmentItemServiceFactory.CreateForEditForPendingItems(consignmentItemRepositoryStub, _jobItemforEditPendingId, supplierId, _userContext);
            EditPendingConsignmentItem(_pendingItemId, _jobItemforEditPendingId, supplierId, instructions);
            Assert.IsTrue(_domainValidationException.ResultContainsMessage(Messages.InstructionsTooLarge));
        }

        [Test]
        public void EditPending_UserHasInsufficientSecurity_DomainValidationException()
        {
            var supplierId = Guid.NewGuid();
            var instructions = "some instructions";

            var consignmentItemRepositoryStub = MockRepository.GenerateMock<IConsignmentItemRepository>();
            consignmentItemRepositoryStub.Stub(x => x.GetPendingItem(_pendingItemId)).Return(_pendingItemForEdit);
            _consignmentItemService = ConsignmentItemServiceFactory.CreateForEditForPendingItems(consignmentItemRepositoryStub, _jobItemforEditPendingId, supplierId,
                TestUserContext.Create("graham.robertson@intertek.com", "Graham Robertson", "Operations Manager", UserRole.Public));
            EditPendingConsignmentItem(_pendingItemId, _jobItemforEditPendingId, supplierId, instructions);
            Assert.IsTrue(_domainValidationException.ResultContainsMessage(Messages.InsufficientSecurityClearance));
        }

        private void EditPendingConsignmentItem(Guid id, Guid jobItemId, Guid supplierId, string instructions)
        {
            try
            {
                _pendingItemForEdit = _consignmentItemService.EditPending(id, jobItemId, supplierId, instructions);
            }
            catch (DomainValidationException dex)
            {
                _domainValidationException = dex;
            }
        }

        #endregion
        #region Edit

        [Test]
        public void Edit_ValidEdit_ItemEdited()
        {
            var instructions = "edited instructions";
            var consignmentItemRepository = MockRepository.GenerateMock<IConsignmentItemRepository>();
            consignmentItemRepository.Stub(x => x.GetById(_consignmentItemForEditId)).Return(_consignmentItemForEdit);
            consignmentItemRepository.Expect(x => x.Update(null)).IgnoreArguments();
            _consignmentItemService = ConsignmentItemServiceFactory.Create(consignmentItemRepository, _userContext);

            Edit(_consignmentItemForEditId, instructions);
            consignmentItemRepository.VerifyAllExpectations();
            Assert.AreEqual(_consignmentItemForEditId, _consignmentItemForEdit.Id);
            Assert.AreEqual(instructions, _consignmentItemForEdit.Instructions);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Edit_InvalidConsignmentItemId_ArgumentExceptionThrown()
        {
            var consignmentItemId = Guid.NewGuid();
            var instructions = "edited instructions";
            var consignmentItemRepository = MockRepository.GenerateMock<IConsignmentItemRepository>();
            consignmentItemRepository.Stub(x => x.GetById(consignmentItemId)).Return(null);
            _consignmentItemService = ConsignmentItemServiceFactory.Create(consignmentItemRepository, _userContext);
            Edit(consignmentItemId, instructions);
        }

        [Test]
        public void Edit_InvalidInstructions_DomainValidationExceptionThrown()
        {
            var instructions = new String('a', 10001);
            var consignmentItemRepository = MockRepository.GenerateMock<IConsignmentItemRepository>();
            consignmentItemRepository.Stub(x => x.GetById(_consignmentItemForEditId)).Return(_consignmentItemForEdit);
            _consignmentItemService = ConsignmentItemServiceFactory.Create(consignmentItemRepository, _userContext);
            Edit(_consignmentItemForEditId, instructions);
            Assert.IsTrue(_domainValidationException.ResultContainsMessage(Messages.InstructionsTooLarge));
        }

        [Test]
        public void Edit_ConsignmentIsOrdered_DomainValidationExceptionThrown()
        {
            _consignmentItemForEdit.Consignment.IsOrdered = true;
            var instructions = "edited instructions";
            var consignmentItemRepository = MockRepository.GenerateMock<IConsignmentItemRepository>();
            consignmentItemRepository.Stub(x => x.GetById(_consignmentItemForEditId)).Return(_consignmentItemForEdit);
            _consignmentItemService = ConsignmentItemServiceFactory.Create(consignmentItemRepository, _userContext);
            Edit(_consignmentItemForEditId, instructions);
            Assert.IsTrue(_domainValidationException.ResultContainsMessage(Messages.ConsignmentIsOrdered));
        }

        private void Edit(Guid consignmentItemId, string instructions)
        {
            try
            {
                _consignmentItemForEdit = _consignmentItemService.Edit(consignmentItemId, instructions);
            }
            catch (DomainValidationException dex)
            {
                _domainValidationException = dex;
            }
        }

        #endregion
    }
}