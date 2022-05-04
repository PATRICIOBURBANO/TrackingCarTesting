using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TrackingCarTesting
{
    [TestClass]
    public class TrackingCarParkTesting
    {



        [TestMethod]
        public void AddingVehicle()
        {
            //Arrange

            var testTracker = new VehicleTracker(3, "Location1");
            var vehicle1 = new Vehicle("MAB256", false);

            //Act

            testTracker.AddVehicle(vehicle1);
           


            //Assert
            Assert.IsTrue(vehicle1 != null);
        }

        [TestMethod]
        public void RemovingVehicle()
        {
            //Arrange

            var testTracker = new VehicleTracker(5, "Location1");
            var vehicle1 = new Vehicle("XXX111", false);

            //Act

            testTracker.AddVehicle(vehicle1);
            testTracker.RemoveVehicle("XXX111");


            //Assert
            Assert.IsTrue(vehicle1 != null);    
        }


        [TestMethod]
        public void CheckOverCapacity()
        {
            //Arrange
            int capacity = 5;
            string locationName = "550Portage";
            
             //Act
            var testTracker = new VehicleTracker(capacity, locationName);
            var vehicle1 = new Vehicle("JJJ000",false);
            testTracker.AddVehicle(vehicle1);


            //Assert
            Assert.AreEqual(capacity, testTracker.Capacity);
                
        }


        [TestMethod]
        public void CheckSlotsAvailable()
        {
            //Arrange
            int capacity = 1;
            string locationName = "550Portage";

            //Act
            var testTracker = new VehicleTracker(capacity, locationName);
            var vehicle1 = new Vehicle("XXX111", false);
            testTracker.AddVehicle(vehicle1);


            //Assert
            Assert.AreEqual(testTracker.SlotsAvailable, 0);
        }
    }
}