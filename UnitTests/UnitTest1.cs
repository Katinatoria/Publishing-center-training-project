using Microsoft.VisualStudio.TestTools.UnitTesting;
using UP0201_Publishing_Center;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void role_1_1_1()
        {
            string lg = "1";
            string pas = "1";
            string expected = "1";

            authorization auth = new authorization();
            string actual = auth.check_role(lg, pas);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void role_2_2_2()
        {
            string lg = "2";
            string pas = "2";
            string expected = "2";

            authorization auth = new authorization();
            string actual = auth.check_role(lg, pas);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void existence_2_2_1()
        {
            string lg = "2";
            string pas = "2";
            string expected = "1";

            authorization auth = new authorization();
            string actual = auth.check_existence_user(lg, pas);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void existence_1_1_1()
        {
            string lg = "1";
            string pas = "1";
            string expected = "1";

            authorization auth = new authorization();
            string actual = auth.check_existence_user(lg, pas);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void search_id_writer_AMA_4()
        {
            string name_wr = "Александрова Маргарита Александрова";
            string expected = "4";

            manager manager = new manager();
            string actual = manager.search_id_writer(name_wr);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void search_id_writer_KMS_9()
        {
            string name_wr = "Кожаков Михаил Сергеевич";
            string expected = "9";

            manager manager = new manager();
            string actual = manager.search_id_writer(name_wr);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void search_id_book_BVB_1()
        {
            string name_book = "Бебры в беброузе";
            string expected = "1";

            manager manager = new manager();
            string actual = manager.search_id_book(name_book);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void search_id_book_JMST_2()
        {
            string name_book = "Жизнь мафиозника Сергея Тарантайки";
            string expected = "2";

            manager manager = new manager();
            string actual = manager.search_id_book(name_book);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void search_fee_JMST_3000000()
        {
            string name_book = "Жизнь мафиозника Сергея Тарантайки";
            string expected = "3000000,00";

            manager manager = new manager();
            string actual = manager.search_fee(name_book);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void search_fee_BVB_100000000()
        {
            string name_book = "Бебры в беброузе";
            string expected = "100000000,00";

            manager manager = new manager();
            string actual = manager.search_fee(name_book);

            Assert.AreEqual(expected, actual);
        }
    }
}
