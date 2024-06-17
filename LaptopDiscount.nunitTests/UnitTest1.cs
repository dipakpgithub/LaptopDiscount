namespace LaptopDiscount.nunitTests
{
    public class Tests
    {
        [Test]
        public void CalculateDiscountedPrice_PartTimeEmployee_NoDiscount()
        {
            // Arrange
            var employeeDiscount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.PartTime,
                Price = 1000m
            };

            // Act
            var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.AreEqual(1000m, discountedPrice);
        }

        [Test]
        public void CalculateDiscountedPrice_PartialLoadEmployee_5PercentDiscount()
        {
            // Arrange
            var employeeDiscount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.PartialLoad,
                Price = 1000m
            };

            // Act
            var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.AreEqual(950m, discountedPrice);
        }

        [Test]
        public void CalculateDiscountedPrice_FullTimeEmployee_10PercentDiscount()
        {
            // Arrange
            var employeeDiscount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.FullTime,
                Price = 1000m
            };

            // Act
            var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.AreEqual(900m, discountedPrice);
        }

        [Test]
        public void CalculateDiscountedPrice_CompanyPurchasing_20PercentDiscount()
        {
            // Arrange
            var employeeDiscount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.CompanyPurchasing,
                Price = 1000m
            };

            // Act
            var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.AreEqual(800m, discountedPrice);
        }

        [Test]
        public void CalculateDiscountedPrice_PriceIsZero_NoDiscount()
        {
            // Arrange
            var employeeDiscount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.FullTime,
                Price = 0m
            };

            // Act
            var discountedPrice = employeeDiscount.CalculateDiscountedPrice();

            // Assert
            Assert.AreEqual(0m, discountedPrice);
        }

        [Test]
        public void CalculateDiscountedPrice_NegativePrice()
        {
            // Arrange
            var employeeDiscount = new EmployeeDiscount
            {
                EmployeeType = EmployeeType.FullTime,
                Price = -1000m
            };
            // Act
            var discountedPrice = employeeDiscount.CalculateDiscountedPrice();


            // Assert
            Assert.AreEqual(-900m, discountedPrice);
        }

    }
}