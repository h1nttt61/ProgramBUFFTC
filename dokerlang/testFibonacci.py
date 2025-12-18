import unittest
import Fibonacci

class Tests(unittest.TestCase):
    def test_pos(self):
        self.assertEqual(Fibonacci.fibonacci(10), 55)
        self.assertEqual(Fibonacci.fibonacci(15), 610)
    def test_neg(self):
         self.assertEqual(Fibonacci.fibonacci(-5), 0)

if __name__ == "__main__":
    unittest.main()
