using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ExamTwoCodeQuestions.Data
{
    public class Cobbler : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// To implement the INotifyPropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// The fuit used in the cobbler
        /// </summary>
        private FruitFilling fruit;
        /// <summary>
        /// The fruit used in the cobbler
        /// </summary>
        public FruitFilling Fruit {
            get
            {
                return fruit;
            }

            set
            {
                fruit = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fruit"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cherry"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Peach"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Blueberry"));

            }

        }

        /// <summary>
        /// If the flavor is BlueBerry or not
        /// </summary>
        public bool Blueberry
        {
            get
            {
                if(Fruit == FruitFilling.Blueberry)
                {
                    return true;
                }

                return false;
            }
            set
            {
                Fruit = FruitFilling.Blueberry;

            }
        }

        /// <summary>
        /// If the flavor is Cherry or not
        /// </summary>
        public bool Cherry
        {
            get
            {
                if (Fruit == FruitFilling.Cherry)
                {
                    return true;
                }

                return false;
            }
            set
            {
                Fruit = FruitFilling.Cherry;

            }
        }


        /// <summary>
        /// If the flavor is Peach or not
        /// </summary>
        public bool Peach
        {
            get
            {
                if (Fruit == FruitFilling.Peach)
                {
                    return true;
                }

                return false;
            }
            set
            {
                Fruit = FruitFilling.Peach;

            }
        }



        private bool withIceCream = true;
        /// <summary>
        /// If the cobbler is served with ice cream
        /// </summary>
        public bool WithIceCream
        {
            get
            {
                return withIceCream;
            }
            set
            {
                withIceCream = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("WithIceCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));

            }
        }

        /// <summary>
        /// Gets the price of the Cobbler
        /// </summary>
        public double Price
        {
            get
            {
                if (WithIceCream) return 5.32;
                else return 4.25;
            }
        }

        /// <summary>
        /// Gets any special instructions for preparing this dessert
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                if(WithIceCream) { return new List<string>(); }
                else { return new List<string>() { "Hold Ice Cream" }; }
            }
        }


    }
}
