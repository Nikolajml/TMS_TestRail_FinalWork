using Newtonsoft.Json.Linq;
using NLog;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_TestRail_FinalWork.BaseEntities;
using TMS_TestRail_FinalWork.Clients;
using TMS_TestRail_FinalWork.Models;
using TMS_TestRail_FinalWork.Models.Api;
using TMS_TestRail_FinalWork.Services;
using TMS_TestRail_FinalWork.Utilities.Helpers;

namespace TMS_TestRail_FinalWork.Tests.API
{
    public class UserTestApi : BaseApiTest
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public int Id { get; set; }

        [Test, Order (1)]
        public void AddNewUser()
        {
            var expectedUser = new UserModelApi();
            expectedUser.Name = "Roman Volkov Ostr";
            expectedUser.Email = "RVolkov@yandex.ru";            

            var actualUser = _userService.AddUser(expectedUser);
            _logger.Info("jsonObject: " + actualUser.ToString());

            //Выполним десериализацию JSON - строки в объект JObject
            var jsonObject = JObject.Parse(actualUser.Content);

            //Использование JsonPath для извлечения занчения из объекта
            string actualName = jsonObject.SelectToken("$.name").Value<string>();

            //Получение Id для UpdateTestCase
            var jsonObjectId = JObject.Parse(actualUser.Content);
            Id = jsonObjectId.SelectToken("$.id").Value<int>();
            _logger.Info("Id: " + Id);
            Console.WriteLine("Test: " + Id);

            Assert.AreEqual(expectedUser.Name, actualName);
        }

        [Test, Order(2)]        
        public void GetUserTest()
        {
            var actualCase = _userService.GetUser(Id);
            _logger.Info(actualCase.Content);

            int actualId = JObject.Parse(actualCase.Content).SelectToken("$.id").Value<int>();

            Console.WriteLine("Test: " + actualId);

            Assert.AreEqual(Id, actualId);
        }
    }
}
