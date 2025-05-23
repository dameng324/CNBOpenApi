/*
 * CNB OPENAPI
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Contact: cnb@tencent.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using CNBOpenApi.Api;
using CNBOpenApi.Model;


/* *********************************************************************************
*              Follow these manual steps to construct tests.
*              This file will not be overwritten.
*  *********************************************************************************
* 1. Navigate to ApiTests.Base.cs and ensure any tokens are being created correctly.
*    Take care not to commit credentials to any repository.
*
* 2. Mocking is coordinated by ApiTestsBase#AddApiHttpClients.
*    To mock the client, use the generic AddApiHttpClients.
*    To mock the server, change the client's BaseAddress.
*
* 3. Locate the test you want below
*      - remove the skip property from the Fact attribute
*      - set the value of any variables if necessary
*
* 4. Run the tests and ensure they work.
*
*/


namespace CNBOpenApi.Test.Api
{
    /// <summary>
    ///  Class for testing CollaboratorsApi
    /// </summary>
    public sealed class CollaboratorsApiTests : ApiTestsBase
    {
        private readonly ICollaboratorsApi _instance;

        public CollaboratorsApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<ICollaboratorsApi>();
        }

        /// <summary>
        /// Test AddMembersOfGroup
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task AddMembersOfGroupAsyncTest()
        {
            string group = default!;
            string username = default!;
            DtoUpdateMembersRequest request = default!;
            await _instance.AddMembersOfGroupAsync(group, username, request);
        }

        /// <summary>
        /// Test AddMembersOfMission
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task AddMembersOfMissionAsyncTest()
        {
            string mission = default!;
            string username = default!;
            DtoUpdateMembersRequest request = default!;
            await _instance.AddMembersOfMissionAsync(mission, username, request);
        }

        /// <summary>
        /// Test AddMembersOfRegistry
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task AddMembersOfRegistryAsyncTest()
        {
            string registry = default!;
            string username = default!;
            DtoUpdateMembersRequest request = default!;
            await _instance.AddMembersOfRegistryAsync(registry, username, request);
        }

        /// <summary>
        /// Test AddMembersOfRepo
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task AddMembersOfRepoAsyncTest()
        {
            string repo = default!;
            string username = default!;
            DtoUpdateMembersRequest request = default!;
            await _instance.AddMembersOfRepoAsync(repo, username, request);
        }

        /// <summary>
        /// Test DeleteMembersOfGroup
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task DeleteMembersOfGroupAsyncTest()
        {
            string group = default!;
            string username = default!;
            await _instance.DeleteMembersOfGroupAsync(group, username);
        }

        /// <summary>
        /// Test DeleteMembersOfRepo
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task DeleteMembersOfRepoAsyncTest()
        {
            string repo = default!;
            string username = default!;
            await _instance.DeleteMembersOfRepoAsync(repo, username);
        }

        /// <summary>
        /// Test DeleteOutsideCollaborators
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task DeleteOutsideCollaboratorsAsyncTest()
        {
            string repo = default!;
            string username = default!;
            await _instance.DeleteOutsideCollaboratorsAsync(repo, username);
        }

        /// <summary>
        /// Test ListAllMembers
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task ListAllMembersAsyncTest()
        {
            string repo = default!;
            Client.Option<int> page = default!;
            Client.Option<int> pageSize = default!;
            Client.Option<string> role = default!;
            Client.Option<string> search = default!;
            Client.Option<string> names = default!;
            Client.Option<string> orderBy = default!;
            Client.Option<bool> desc = default!;
            var response = await _instance.ListAllMembersAsync(repo, page, pageSize, role, search, names, orderBy, desc);
            var model = response.Ok();
            Assert.IsType<List<DtoUsersWithAccessLevelInSlug>>(model);
        }

        /// <summary>
        /// Test ListInheritMembersOfGroup
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task ListInheritMembersOfGroupAsyncTest()
        {
            string group = default!;
            Client.Option<string> search = default!;
            Client.Option<string> role = default!;
            Client.Option<int> page = default!;
            Client.Option<int> pageSize = default!;
            var response = await _instance.ListInheritMembersOfGroupAsync(group, search, role, page, pageSize);
            var model = response.Ok();
            Assert.IsType<List<DtoListInheritMembers>>(model);
        }

        /// <summary>
        /// Test ListInheritMembersOfRepo
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task ListInheritMembersOfRepoAsyncTest()
        {
            string repo = default!;
            Client.Option<string> search = default!;
            Client.Option<string> role = default!;
            Client.Option<int> page = default!;
            Client.Option<int> pageSize = default!;
            var response = await _instance.ListInheritMembersOfRepoAsync(repo, search, role, page, pageSize);
            var model = response.Ok();
            Assert.IsType<List<DtoListInheritMembers>>(model);
        }

        /// <summary>
        /// Test ListMembersOfGroup
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task ListMembersOfGroupAsyncTest()
        {
            string group = default!;
            Client.Option<int> page = default!;
            Client.Option<int> pageSize = default!;
            Client.Option<string> role = default!;
            Client.Option<string> search = default!;
            var response = await _instance.ListMembersOfGroupAsync(group, page, pageSize, role, search);
            var model = response.Ok();
            Assert.IsType<List<DtoUsersWithAccessLevelInSlug>>(model);
        }

        /// <summary>
        /// Test ListMembersOfRepo
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task ListMembersOfRepoAsyncTest()
        {
            string repo = default!;
            Client.Option<int> page = default!;
            Client.Option<int> pageSize = default!;
            Client.Option<string> role = default!;
            Client.Option<string> search = default!;
            var response = await _instance.ListMembersOfRepoAsync(repo, page, pageSize, role, search);
            var model = response.Ok();
            Assert.IsType<List<DtoUsersWithAccessLevelInSlug>>(model);
        }

        /// <summary>
        /// Test ListOutsideCollaborators
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task ListOutsideCollaboratorsAsyncTest()
        {
            string repo = default!;
            Client.Option<int> page = default!;
            Client.Option<int> pageSize = default!;
            Client.Option<string> role = default!;
            Client.Option<string> search = default!;
            var response = await _instance.ListOutsideCollaboratorsAsync(repo, page, pageSize, role, search);
            var model = response.Ok();
            Assert.IsType<List<DtoOutsideCollaboratorInRepo>>(model);
        }

        /// <summary>
        /// Test TopContributors
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TopContributorsAsyncTest()
        {
            string repo = default!;
            Client.Option<int> top = default!;
            var response = await _instance.TopContributorsAsync(repo, top);
            var model = response.Ok();
            Assert.IsType<List<DtoUsersResult>>(model);
        }

        /// <summary>
        /// Test UpdateMembersOfGroup
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UpdateMembersOfGroupAsyncTest()
        {
            string group = default!;
            string username = default!;
            DtoUpdateMembersRequest request = default!;
            await _instance.UpdateMembersOfGroupAsync(group, username, request);
        }

        /// <summary>
        /// Test UpdateMembersOfRepo
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UpdateMembersOfRepoAsyncTest()
        {
            string repo = default!;
            string username = default!;
            DtoUpdateMembersRequest request = default!;
            await _instance.UpdateMembersOfRepoAsync(repo, username, request);
        }

        /// <summary>
        /// Test UpdateOutsideCollaborators
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UpdateOutsideCollaboratorsAsyncTest()
        {
            string repo = default!;
            string username = default!;
            string role = default!;
            await _instance.UpdateOutsideCollaboratorsAsync(repo, username, role);
        }
    }
}
