using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Pooler;
using System.Threading;

namespace WinFormsApplicationParallelTest {
	public partial class Main {
		public void TestJob (Pooler.Base pool) {
			int i = 0;
			lock (this._taskBeginCounterLock) {
				i = this._taskBeginCounter;
				this._taskBeginCounter++;
			}
			// some dummy computation to execute
			long nthPrime;
			// find prime numbers for first time
			nthPrime = this.TestJobToFindPrimeNumbers(1000);
			// wait for sime time if there is set in pool any
			pool.Pause();
			if (Main.N_EXCEPTIONS > 1) {
				if (i % 3 == Main.N_EXCEPTIONS) {
					throw new Exception($"Exception modulo " + Main.N_EXCEPTIONS);
				}
			}
			// find prime numbers for second time
			nthPrime = this.TestJobToFindPrimeNumbers(1000);
		}

		public long TestJobToFindPrimeNumbers (int n) {
			int count=0;
			long a = 2;
			while (count < n) {
				long b = 2;
				int prime = 1;// to check if found a prime
				while (b * b <= a) {
					if (a % b == 0) {
						prime = 0;
						break;
					}
					b++;
				}
				if (prime > 0) {
					count++;
				}
				a++;
			}
			return (--a);
		}
	}
}
