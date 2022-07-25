using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace IntermediateII {
	class Program {
		
		// usando cola
		static int[] ReverseWithQueue(int[] arr) {
			Queue<int> myQueue = new Queue<int>();
			foreach (int i in arr)
				myQueue.Enqueue(i);
			return myQueue.Reverse().ToArray();
		}

		// usando lista
		static int[] ReverseWithList(int[] arr) {
			List<int> myList = new List<int>();
			foreach (int i in arr)
				myList.Add(i);
			myList.Reverse();
			return myList.ToArray();
		}

		// usando diccionario
		static int[] ReverseWithDictionary(int[] arr) {
			Dictionary<string, int> myDict = new Dictionary<string, int>();
			for (int i = 0; i < arr.Length; i++)
				myDict.Add($"Index_{i}", arr[i]);
			return myDict.Values.Reverse().ToArray();
		}

		// verificar que una cadena de texto sea palindromo
		static bool IsPalindrome(string str) {
			string palindrome = "";
			str = str.Replace(" ", String.Empty);
			Stack<char> myStack = new Stack<char>(str);

			while (myStack.Count != 0)
				palindrome += myStack.Pop();

			return str.Equals(palindrome);
		}

		static void Main(string[] args) {
			List<(int, int)> myListTuple = new List<(int, int)>();
			List<(string Name, string Kind, int Replicas, bool Run)> mySecondListTyple =
				new List<(string Name, string Kind, int Replicas, bool Run)>();

			int k;
			int maxSize = 1000000;
			int[] toReverseArray = { 1, 2, 3, 4, 5, 6 };
			int[] reversedArray;
			string checkPalindrome;

			ReferenceExample[] myClass = new ReferenceExample[maxSize];
			ValueExample[] myStruct = new ValueExample[maxSize];

			Stopwatch stopwatch = new Stopwatch();

			myListTuple.Add((11, 25));
			myListTuple.Add((12, 25));
			myListTuple.Add((10, 10));
			myListTuple.Add((09, 16));

			mySecondListTyple.Add(("pablo", "Unknown", 3, false));
			mySecondListTyple.Add(("pablito", "Pablian", 25, true));
			mySecondListTyple.Add(("pablon", "Human", 8, true));
			mySecondListTyple.Add(("mengano", "Mengian", 0, false));

			myListTuple.ForEach(x => Console.WriteLine(x));
			mySecondListTyple.ForEach(x => Console.WriteLine(x));

			stopwatch.Start();
			for (k = 0; k < maxSize; k++) {
				myClass[k] = new ReferenceExample(k, "nombre", "pass");
			}

			stopwatch.Stop();
			var referenceElapsed = stopwatch.Elapsed;

			stopwatch.Restart();
			for (k = 0; k < maxSize; k++) {
				myStruct[k] = new ValueExample(k, "nombre", "pass");
			}

			stopwatch.Stop();
			var valueElapsed = stopwatch.Elapsed;

			Console.WriteLine($"Referencia: {referenceElapsed.TotalMilliseconds}ms vs Valor: {valueElapsed.TotalMilliseconds}ms");

			stopwatch.Restart();
			reversedArray = ReverseWithList(toReverseArray);
			stopwatch.Stop();
			var listElapsed = stopwatch.Elapsed;

			stopwatch.Restart();
			reversedArray = ReverseWithDictionary(toReverseArray);
			stopwatch.Stop();
			var dictElapsed = stopwatch.Elapsed;
			
			stopwatch.Restart();
			reversedArray = ReverseWithQueue(toReverseArray);
			stopwatch.Stop();
			var queueElapsed = stopwatch.Elapsed;
			
			Console.WriteLine($"Primer elemento del arreglo inverso: {reversedArray[0]}");
			Console.WriteLine($"Cola: {queueElapsed.TotalMilliseconds}");
			Console.WriteLine($"lista: {listElapsed.TotalMilliseconds}ms");
			Console.WriteLine($"Diccionario: {dictElapsed.TotalMilliseconds}ms");
			
			checkPalindrome = "anita lava la tina";
			Console.WriteLine($"{checkPalindrome} es palindromo? {IsPalindrome(checkPalindrome)}");

		}
		
	}
}