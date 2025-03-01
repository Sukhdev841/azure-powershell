﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.WindowsAzure.Commands.Common.Storage.ResourceModel;
using Microsoft.WindowsAzure.Commands.Storage.Common;
using Microsoft.WindowsAzure.Commands.Storage.Queue;
using Microsoft.Azure.Storage.Queue;

namespace Microsoft.WindowsAzure.Commands.Storage.Test.Queue
{
    [TestClass]
    public class GetAzureStorageQueueTest : StorageQueueTestBase
    {
        public GetAzureStorageQueueCommand command = null;

        [TestInitialize]
        public void InitCommand()
        {
            command = new GetAzureStorageQueueCommand(queueMock)
            {
                CommandRuntime = MockCmdRunTime
            };
        }

        [TestCleanup]
        public void CleanCommand()
        {
            command = null;
        }

        [TestMethod]
        public void ExecuteCommandGetQueueTest()
        {
            AddTestQueues();
            command.Name = "test";
            command.ExecuteCmdlet();
            Assert.AreEqual(1, MockCmdRunTime.OutputPipeline.Count);

            AzureStorageQueue queue = (AzureStorageQueue)MockCmdRunTime.OutputPipeline.FirstOrDefault();
            Assert.AreEqual(command.Name, queue.Name);
        }
    }
}
