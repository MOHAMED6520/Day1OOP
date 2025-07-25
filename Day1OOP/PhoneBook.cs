﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day1OOP
{
    internal struct PhoneBook
    {
        string[] names;
        long[] numbers;
        public PhoneBook (int size)
        {
            names = new string[size];
            numbers = new long[size];
        }
        public void AddPerson (string name , long phone , int index)
        {
            names[index] = name;
            numbers[index] = phone;
        }

        public long this[string name]
        {

            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                        return numbers[i];
                }
                return -1;
            }
            set
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                        numbers[i] = value;
                }
            }
        }

        public string this [long number]
            {
            get 
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == number)
                        return names[i];
                }
                return "";
            }

            set
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (numbers[i] == number)
                        names[i] = value;
                }

            }

            }
        public long GetNumber(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                    return numbers[i];
            }
            return -1;
        }

        public void UpdateNumber(string name, long newNumber)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                    numbers[i] = newNumber;
            }
        }

        public string getName(long number)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                    return names[i];
            }
            return "";
        }

        public void UpdateNane(string name, long number)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (numbers[i] == number)
                    names[i] = name;
            }
        }
    }
}
