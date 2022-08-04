namespace Simple.ConsoleApp.Template.Tests
{
    public class Tests
    {
        #region Fields
        Calculator _calcualtor;
        #endregion
        [SetUp]
        public void Setup()
        {
            _calcualtor = new Calculator();
        }

        [Test]
        public void Add_Returns_Addition_Of_Two_Numbers()
        {
            var result = _calcualtor.Add(1, 2);
            
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Substract_Returns_Substraction_Of_Two_Numbers()
        {
            var result = _calcualtor.Substract(1, 2);

            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void Multiply_Returns_Multiplication_Of_Two_Numbers()
        {
            var result = _calcualtor.Multiply(2, 2);

            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Divide_Returns_Division_Of_Two_Numbers()
        {
            var result = _calcualtor.Substract(4, 2);

            Assert.That(result, Is.EqualTo(2));
        }
    }
}