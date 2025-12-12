import unittest

from modules.domain.calculation import Calculation


class TestCalculation(unittest.TestCase):
    def test_add_positive_number_should_make_sum(self):
        res = Calculation.add(1, 1)
        self.assertEqual(2, res)

        res = Calculation.add(5, 8)
        self.assertEqual(13, res)

        res = Calculation.add(100, 10)
        self.assertEqual(110, res)

    def test_add_negatif_number_should_make_subtract(self):
        res = Calculation.add(1, -1)
        self.assertEqual(0, res)

        res = Calculation.add(-5, 8)
        self.assertEqual(3, res)

        res = Calculation.add(-100, 10)
        self.assertEqual(-90, res)

        res = Calculation.add(-10, -10)
        self.assertEqual(-20, res)

    def test_add_zero_should_return_the_other_number(self):
        res = Calculation.add(1, 0)
        self.assertEqual(1, res)

        res = Calculation.add(-5, 0)
        self.assertEqual(-5, res)

        res = Calculation.add(0, 10)
        self.assertEqual(10, res)

        res = Calculation.add(0, 0)
        self.assertEqual(0, res)

    # def test_add_max_value_should_throw_if_upper(self):
    #     with self.assertRaises(ValueError):
    #         Calculation.add(1, MAX_INT)

    #     with self.assertRaises(ValueError):
    #         Calculation.add(8, MAX_INT)

    #     res = Calculation.add(-5, MAX_INT)
    #     self.assertEqual(2147483642, res)

    # def test_add_min_value_should_throw_if_lower(self):
    #     with self.assertRaises(ValueError):
    #         Calculation.add(-5, MIN_INT)

    #     with self.assertRaises(ValueError):
    #         Calculation.add(-8, MIN_INT)

    # def test_add_min_value_should_return_if_is_exactly_the_value(self):
    #     res = Calculation.add(0, MIN_INT)
    #     self.assertEqual(-2147483648, res)

    #     res = Calculation.add(-2147483638, -10)
    #     self.assertEqual(-2147483648, res)

    # def test_add_max_value_should_return_if_is_exactly_the_value(self):
    #     res = Calculation.add(0, MAX_INT)
    #     self.assertEqual(2147483647, res)

    #     res = Calculation.add(2147483637, 10)
    #     self.assertEqual(2147483647, res)


if __name__ == "__main__":
    unittest.main()