using Microsoft.VisualStudio.TestTools.UnitTesting;
using Morqet.ECommerce.Domain.Models.Core.Communication;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadingDataFromExcel.Context
{
    public class CommonChecks
    {
        public static void RequestCheck<T>(RequestViewModel<T> req)
            where T : IRequestData, new()
        {
            Assert.IsNotNull(req, "Request View Model cannot be null");
            Assert.IsNotNull(req.RequestData, "Request Data cannot be null");

        }
        public static void ResponseCheck<T, P>(ResponseViewModel<T, P> res, ResponseStates expectedState)
            where T : IRequestData, new()
            where P : IResponseData, new()
        {
            Assert.IsNotNull(res, "Response View Model cannot be null");
            Assert.IsNotNull(res.RequestData, "Request Data cannot be null");
            Assert.IsNotNull(res.ResponseData, "Response Data cannot be null");
            Assert.IsNotNull(res.Messages, "Messages cannot be null");
            Assert.IsTrue(res.Messages.Count > 0, "Response must have message");
            if (expectedState == ResponseStates.Succeed)
            {
                Assert.AreEqual(expectedState, res.State, res.Messages[0].Description);
            }
            else if (expectedState == ResponseStates.Failed)
            {
                Assert.AreEqual(expectedState, res.State, res.Messages[0].Description);
            }
            else if (expectedState == ResponseStates.ServiceUnavailable)
            {
                Assert.AreEqual(expectedState, res.State, res.Messages[0].Description);
            }
            else
            {
                Assert.Fail("Response state is not valid");
            }

        }
    }
}
