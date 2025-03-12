using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300021
{
    internal class FanLaptop
    {
        private enum State { Quiet, Balance, Performance, Turbo }
        private State currentState;

        public FanLaptop()
        {
            currentState = State.Quiet;
            Console.WriteLine("Fan Quiet");
        }

        public void modeQuiet()
        {
            if (currentState == State.Balance)
            {
                currentState = State.Quiet;
                Console.WriteLine("Fan Balanced berubah menjadi Quiet");
            }
            else if (currentState == State.Turbo)
            {
                Console.WriteLine("Fan Turbo berubah menjadi Quiet");
            }
            else
            {
                Console.WriteLine("Sudah dalam mode Quiet");
            }
        }

        public void modeBalance()
        {
            if (currentState == State.Quiet)
            {
                currentState = State.Balance;
                Console.WriteLine("Fan Quiet berubah menjadi Balanced");
            }

            else if (currentState == State.Performance)
            {
                currentState = State.Balance;
                Console.WriteLine("Fan Performance berubah menjadi Balanced");
            }

            else
            {
                Console.WriteLine("Sudah Mode Balanced");
            }
        }

        public void modePerformance()
        {
            if (currentState == State.Balance)
            {
                currentState = State.Performance;
                Console.WriteLine("Fan Balance berubah menjadi Performance");
            }
            else if (currentState == State.Turbo)
            {
                currentState = State.Performance;
                Console.WriteLine("Fan Turbo berubah menjadi Performance");
            }
            else
            {
                Console.Write("Sudah Mode Performance");
            }
        }

        public void modeTurbo()
        {
            if (currentState == State.Performance)
            {
                currentState = State.Turbo;
                Console.WriteLine("Fan Performance berubah menjadi Turbo");
            }
            else if (currentState == State.Quiet)
            {
                currentState = State.Turbo;
                Console.WriteLine("Fan Quiet berubah menjadi Turbo");
            }
            else
            {
                Console.WriteLine("Sudah Mode Turbo");
            }


        }
    }
}
