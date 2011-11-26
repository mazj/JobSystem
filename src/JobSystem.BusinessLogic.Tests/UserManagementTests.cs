﻿using System;
using JobSystem.BusinessLogic.Services;
using JobSystem.BusinessLogic.Tests.Helpers;
using JobSystem.BusinessLogic.Validation.Core;
using JobSystem.DataModel.Entities;
using JobSystem.DataModel.Repositories;
using NUnit.Framework;
using Rhino.Mocks;

namespace JobSystem.BusinessLogic.Tests
{
	[TestFixture]
	public class UserManagementTests
	{
		private const string GreaterThan256Characters = "jlkasdj;lakjdflksdjlkasdj;lakjdflksdjlkasdj;lakjdflksdjlkasdj;lakjdflksdjlkasdj;lakjdflksdjlkasdj;lakjdflksdjlkasdj;lakjdflksdjlkasdj;lakjdflksdjlkasdj;lakjdflksdjlkasdj;lakjdflksdjlkasdj;lakjdflksdjlkasdj;lakjdflksdjlkasdj;lakjdflksdjlkasdj;lakjdflksdjlkasdj;lakjdflksd";
		private UserManagementService _userManagementService;

		[SetUp]
		public void Setup()
		{
			_userManagementService = UserManagementServiceFactory.Create();
		}

		#region Create

		[Test]
		public void Create_SuccessfullyCreateUser_UserCreated()
		{
			var userRepositoryMock = MockRepository.GenerateMock<IUserAccountRepository>();
			userRepositoryMock.Expect(x => x.Create(null)).IgnoreArguments();
			_userManagementService = UserManagementServiceFactory.Create(userRepositoryMock);
			_userManagementService.Create(Guid.NewGuid(), "Name", "test@email.com", "password", "Job Title");
			userRepositoryMock.VerifyAllExpectations();
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void Create_IdNotSupplied_InvalidOperationExceptionThrown()
		{
			_userManagementService.Create(Guid.Empty, "Name", "test@email.com", "password", "Job Title");
		}

		[Test]
		[ExpectedException(typeof(DomainValidationException))]
		public void Create_NameNotSupplied_DomainValidationExceptionThrown()
		{
			_userManagementService.Create(Guid.NewGuid(), String.Empty, "test@email.com", "password", "Job Title");
		}

		[Test]
		[ExpectedException(typeof(DomainValidationException))]
		public void Create_NameGreaterThan256Characters_DomainValidationExceptionThrown()
		{
			_userManagementService.Create(Guid.NewGuid(), GreaterThan256Characters, "test@email.com", "password", "Job Title");
		}

		[Test]
		[ExpectedException(typeof(DomainValidationException))]
		public void Create_EmailNotSupplied_DomainValidationExceptionThrown()
		{
			_userManagementService.Create(Guid.NewGuid(), "Name", String.Empty, "password", "Job Title");
		}

		[Test]
		[ExpectedException(typeof(DomainValidationException))]
		public void Create_EmailInvalid_DomainValidationExceptionThrown()
		{
			_userManagementService.Create(Guid.NewGuid(), "Name", "t@", "password", "Job Title");
		}

		[Test]
		[ExpectedException(typeof(DomainValidationException))]
		public void Create_EmailGreaterThan256Characters_DomainValidationExceptionThrown()
		{
			_userManagementService.Create(Guid.NewGuid(), "Name", String.Format("test@{0}.com", GreaterThan256Characters), "password", "Job Title");
		}

		[Test]
		[ExpectedException(typeof(DomainValidationException))]
		public void Create_EmailNotUnique_DomainValidationExceptionThrown()
		{
			var userAccountRepositoryStub = MockRepository.GenerateStub<IUserAccountRepository>();
			userAccountRepositoryStub.Stub(x => x.GetByEmail("duplicate@testuser.com", true)).Return(new UserAccount() { EmailAddress = "duplicate@testuser.com" });
			_userManagementService = UserManagementServiceFactory.Create(userAccountRepositoryStub);
			_userManagementService.Create(Guid.NewGuid(), "Name", "duplicate@testuser.com", "password", "Job Title");
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void Create_PasswordNotSupplied_ArgumentExceptionThrown()
		{
			_userManagementService.Create(Guid.NewGuid(), "Name", "test@test.com", String.Empty, "Job Title");
		}

		#endregion
		#region Edit

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void Edit_IdNotSupplied_ArgumentExceptionThrown()
		{
			var id = Guid.NewGuid();
			var user = _userManagementService.Create(id, "Chris", "chris@testuser.com", "p'ssw0rd", "Job Title");
			var userAccountRepositoryStub = MockRepository.GenerateStub<IUserAccountRepository>();
			userAccountRepositoryStub.Stub(x => x.GetById(id)).Return(user);
			_userManagementService = UserManagementServiceFactory.Create(userAccountRepositoryStub);
			_userManagementService.Edit(Guid.Empty, "Chris - edited", "chris@testuser.com", "Job Title");
		}

		[Test]
		[ExpectedException(typeof(ArgumentException))]
		public void Edit_InvalidIdSupplied_ArgumentExceptionThrown()
		{
			var id = Guid.NewGuid();
			var user = _userManagementService.Create(id, "Chris", "chris@testuser.com", "p'ssw0rd", "Job Title");
			var userAccountRepositoryStub = MockRepository.GenerateStub<IUserAccountRepository>();
			userAccountRepositoryStub.Stub(x => x.GetById(id)).Return(user);
			_userManagementService = UserManagementServiceFactory.Create(userAccountRepositoryStub);
			_userManagementService.Edit(Guid.NewGuid(), "Chris - edited", "chris@testuser.com", "Job Title");
		}

		[Test]
		[ExpectedException(typeof(DomainValidationException))]
		public void Edit_NameGreaterThan256Characters_DomainValidationExceptionThrown()
		{
			var id = Guid.NewGuid();
			var user = _userManagementService.Create(id, "Chris", "chris@testuser.com", "p'ssw0rd", "Job Title");
			var userAccountRepositoryStub = MockRepository.GenerateStub<IUserAccountRepository>();
			userAccountRepositoryStub.Stub(x => x.GetById(id)).Return(user);
			_userManagementService = UserManagementServiceFactory.Create(userAccountRepositoryStub);
			_userManagementService.Edit(id, GreaterThan256Characters, "chris@testuser.com", "Job Title");
		}

		[Test]
		[ExpectedException(typeof(DomainValidationException))]
		public void Edit_NameNotSupplied_DomainValidationExceptionThrown()
		{
			var id = Guid.NewGuid();
			var user = _userManagementService.Create(id, "Chris", "chris@testuser.com", "p'ssw0rd", "Job Title");
			var userAccountRepositoryStub = MockRepository.GenerateStub<IUserAccountRepository>();
			userAccountRepositoryStub.Stub(x => x.GetById(id)).Return(user);
			_userManagementService = UserManagementServiceFactory.Create(userAccountRepositoryStub);
			_userManagementService.Edit(id, String.Empty, "chris@testuser.com", "Job Title");
		}

		[Test]
		[ExpectedException(typeof(DomainValidationException))]
		public void Edit_EmailNotSupplied_DomainValidationExceptionThrown()
		{
			var id = Guid.NewGuid();
			var user = _userManagementService.Create(id, "Chris", "chris@testuser.com", "p'ssw0rd", "Job Title");
			var userAccountRepositoryStub = MockRepository.GenerateStub<IUserAccountRepository>();
			userAccountRepositoryStub.Stub(x => x.GetById(id)).Return(user);
			_userManagementService = UserManagementServiceFactory.Create(userAccountRepositoryStub);
			_userManagementService.Edit(id, "Chris", String.Empty, "Job Title");
		}

		[Test]
		[ExpectedException(typeof(DomainValidationException))]
		public void Edit_InvalidEmailSupplied_DomainValidationExceptionThrown()
		{
			var id = Guid.NewGuid();
			var user = _userManagementService.Create(id, "Chris", "chris@testuser.com", "p'ssw0rd", "Job Title");
			var userAccountRepositoryStub = MockRepository.GenerateStub<IUserAccountRepository>();
			userAccountRepositoryStub.Stub(x => x.GetById(id)).Return(user);
			_userManagementService = UserManagementServiceFactory.Create(userAccountRepositoryStub);
			_userManagementService.Edit(id, "Chris", "chris@", "Job Title");
		}

		[Test]
		[ExpectedException(typeof(DomainValidationException))]
		public void Edit_EmailGreaterThan256Characters_DomainValidationExceptionThrown()
		{
			var id = Guid.NewGuid();
			var user = _userManagementService.Create(id, "Chris", "chris@testuser.com", "p'ssw0rd", "Job Title");
			var userAccountRepositoryStub = MockRepository.GenerateStub<IUserAccountRepository>();
			userAccountRepositoryStub.Stub(x => x.GetById(id)).Return(user);
			_userManagementService = UserManagementServiceFactory.Create(userAccountRepositoryStub);
			_userManagementService.Edit(id, "Chris", String.Format("chris@{0}", GreaterThan256Characters), "Job Title");
		}

		[Test]
		[ExpectedException(typeof(DomainValidationException))]
		public void Edit_NonUniqueEmailSupplied_DomainValidationExceptionThrown()
		{
			var id = Guid.NewGuid();
			var user = _userManagementService.Create(id, "Chris", "chris@testuser.com", "p'ssw0rd", "Job Title");
			var user2 = _userManagementService.Create(Guid.NewGuid(), "Chris2", "chris2@testuser.com", "p'ssw0rd", "Job Title");
			var userAccountRepositoryStub = MockRepository.GenerateStub<IUserAccountRepository>();
			userAccountRepositoryStub.Stub(x => x.GetById(id)).Return(user);
			userAccountRepositoryStub.Stub(x => x.GetByEmail("chris2@testuser.com", true)).Return(user2);
			_userManagementService = UserManagementServiceFactory.Create(userAccountRepositoryStub);
			_userManagementService.Edit(id, "Chris", "chris2@testuser.com", "Job Title");
		}

		[Test]
		[ExpectedException(typeof(DomainValidationException))]
		public void Edit_JobTitleNotSupplied_DomainValidationExceptionThrown()
		{
			var id = Guid.NewGuid();
			var user = _userManagementService.Create(id, "Chris", "chris@testuser.com", "p'ssw0rd", "Job Title");
			var userAccountRepositoryStub = MockRepository.GenerateStub<IUserAccountRepository>();
			userAccountRepositoryStub.Stub(x => x.GetById(id)).Return(user);
			_userManagementService = UserManagementServiceFactory.Create(userAccountRepositoryStub);
			_userManagementService.Edit(id, "Chris", "chris@testuser.com", String.Empty);
		}

		[Test]
		[ExpectedException(typeof(DomainValidationException))]
		public void Edit_JobTitleGreaterThan256Characters_DomainValidationExceptionThrown()
		{
			var id = Guid.NewGuid();
			var user = _userManagementService.Create(id, "Chris", "chris@testuser.com", "p'ssw0rd", "Job Title");
			var userAccountRepositoryStub = MockRepository.GenerateStub<IUserAccountRepository>();
			userAccountRepositoryStub.Stub(x => x.GetById(id)).Return(user);
			_userManagementService = UserManagementServiceFactory.Create(userAccountRepositoryStub);
			_userManagementService.Edit(id, "Chris", "chris@testuser.com", GreaterThan256Characters);
		}

		[Test]
		public void Edit_SuccessfullyEditUser_UserEdited()
		{
			var id = Guid.NewGuid();
			var user = _userManagementService.Create(id, "Chris", "chris@testuser.com", "p'ssw0rd", "Job Title");
			var userAccountRepositoryMock = MockRepository.GenerateMock<IUserAccountRepository>();
			userAccountRepositoryMock.Stub(x => x.GetById(id)).Return(user);
			userAccountRepositoryMock.Expect(x => x.Update(null)).IgnoreArguments();
			_userManagementService = UserManagementServiceFactory.Create(userAccountRepositoryMock);
			_userManagementService.Edit(id, "Chris - edited", "chris2@testuser.com", "Job Title - edited");
			userAccountRepositoryMock.VerifyAllExpectations();
		}

		#endregion
		#region Login

		[Test]
		[ExpectedException(typeof(DomainValidationException))]
		public void Login_EmailNotSupplied_DomainValidationExceptionThrown()
		{
			_userManagementService.Login(String.Empty, "password");
		}

		[Test]
		[ExpectedException(typeof(DomainValidationException))]
		public void Login_InvalidEmailSupplied_DomainValidationExceptionThrown()
		{
			_userManagementService.Login("blah@blah.com", "password");
		}

		[Test]
		[ExpectedException(typeof(DomainValidationException))]
		public void Login_ValidUserWithNoPasswordSupplied_DomainValidationExceptionThrown()
		{
			var userAccountRepositoryStub = MockRepository.GenerateStub<IUserAccountRepository>();
			userAccountRepositoryStub.Stub(x => x.GetByEmail("blah@blah.com", false)).Return(new UserAccount() { EmailAddress = "blah@blah.com" });
			_userManagementService = UserManagementServiceFactory.Create(userAccountRepositoryStub);
			_userManagementService.Login("blah@blah.com", String.Empty);
		}

		[Test]
		public void Login_ValidUserWithInvalidPasswordSupplied_LoginFails()
		{
			var emailAddress = "chris@testuser.com";
			var user = _userManagementService.Create(Guid.NewGuid(), "Chris", emailAddress, "p'ssw0rd", "Job Title");
			var userAccountRepositoryStub = MockRepository.GenerateStub<IUserAccountRepository>();
			userAccountRepositoryStub.Stub(x => x.GetByEmail(emailAddress, false)).Return(user);
			_userManagementService = UserManagementServiceFactory.Create(userAccountRepositoryStub);
			var loggedIn = _userManagementService.Login(emailAddress, "password");
			Assert.IsFalse(loggedIn);
		}

		[Test]
		public void Login_ValidUserWithValidPasswordSupplied_LoginSuccess()
		{
			var emailAddress = "chris@testuser.com";
			var user = _userManagementService.Create(Guid.NewGuid(), "Chris", emailAddress, "p'ssw0rd", "Job Title");
			var userAccountRepositoryStub = MockRepository.GenerateStub<IUserAccountRepository>();
			userAccountRepositoryStub.Stub(x => x.GetByEmail(emailAddress, false)).Return(user);
			_userManagementService = UserManagementServiceFactory.Create(userAccountRepositoryStub);
			var loggedIn = _userManagementService.Login(emailAddress, "p'ssw0rd");
			Assert.IsTrue(loggedIn);
		}

		#endregion
	}
}