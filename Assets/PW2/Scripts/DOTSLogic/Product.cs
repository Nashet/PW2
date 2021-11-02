using System;
using System.Collections.Generic;
using UnityEngine;

namespace PW2
{
    public enum ProductionType 
    {
        military,
        industrial,
        consumerProduct
    }
    
    public enum Products 
    {
        beer,
        meat,
        guns,
        firewood,
        clothes
    }

    public class Product
    {
        public static readonly List<Product> allProducts = new List<Product>();
        protected static int resourceCounter;

        public readonly decimal defaultPrice;

        protected readonly bool _isResource;
        protected readonly bool _isAbstract;
        protected readonly bool _isMilitary;
        protected readonly bool _isIndustrial;
        protected readonly bool _isConsumerProduct;
        protected readonly Color color;
        protected readonly List<Product> substitutes;
        public bool _isMovable { get; } = false;
        public bool _isStoreable { get; } = false;
        public byte Id { get; }

        //protected Invention[] requiredInventions;

        public static readonly Product
            //Fish, Grain, Cattle, Wood, Lumber, Furniture, Gold, Metal, MetalOre,
            //Cotton, Clothes, Stone, Cement, Fruit, Liquor, ColdArms, Ammunition, Firearms, Artillery,
            //Oil, MotorFuel, Cars, Tanks, Airplanes, Rubber, Machinery,
            Fish = new Product("Fish", 0.04m, Color.cyan, ProductionType.consumerProduct),
            Grain = new Product("Grain", 0.04m, new Color(0.57f, 0.75f, 0.2f), ProductionType.industrial), //greenish
            Cattle = new Product("Cattle", 0.04m, ProductionType.military),
            Fruit = new Product("Fruit", 1m, new Color(1f, 0.33f, 0.33f), ProductionType.consumerProduct), //pinkish
            Liquor = new Product("Liquor", 3m, ProductionType.consumerProduct),
            Wood = new Product("Wood", 2.7m, new Color(0.5f, 0.25f, 0f), ProductionType.industrial), // brown
            Lumber = new Product("Lumber", 8m, ProductionType.industrial),
            Furniture = new Product("Furniture", 7m, ProductionType.consumerProduct),
            Cotton = new Product("Cotton", 1m, Color.white, ProductionType.consumerProduct),
            Clothes = new Product("Clothes", 6m, ProductionType.consumerProduct),
            Stone = new Product("Stone", 1m, new Color(0.82f, 0.62f, 0.82f), ProductionType.industrial);
            //Cement = new Product("Cement", 2m, type.industrial,Invention.SteamPower),
            // MetalOre = new Product("Metal ore", 3m, Color.blue, ProductionType.industrial, Invention.Metal),
            // Metal = new Product("Metal", 6m, ProductionType.industrial, Invention.Metal),
            // ColdArms = new Product("Cold arms", 13m, ProductionType.military, Invention.Metal),
            // Ammunition = new Product("Ammunition", 13m, ProductionType.military, Invention.Gunpowder),
            // Firearms = new Product("Firearms", 13m, ProductionType.military, Invention.Firearms),
            // Artillery = new Product("Artillery", 13m, ProductionType.military, Invention.Gunpowder),
            // Oil = new Product("Oil", 10m, new Color(0.25f, 0.25f, 0.25f), ProductionType.military, Invention.CombustionEngine),
            // MotorFuel = new Product("Motor Fuel", 15m, ProductionType.military, Invention.CombustionEngine),
            // Machinery = new Product("Machinery", 8m, ProductionType.industrial, Invention.SteamPower),
            // Rubber = new Product("Rubber", 10m, new Color(0.67f, 0.67f, 0.47f), ProductionType.industrial, Invention.CombustionEngine), //light grey
            // Cars = new Product("Cars", 15m, ProductionType.military, Invention.CombustionEngine),
            // Tanks = new Product("Tanks", 20m, ProductionType.military, Invention.Tanks),
            // Airplanes = new Product("Airplanes", 20m, ProductionType.military, Invention.Airplanes),
            // Coal = new Product("Coal", 1m, Color.black, ProductionType.industrial, Invention.Coal),
            // Tobacco = new Product("Tobacco", 1m, Color.green, ProductionType.consumerProduct, Invention.Tobacco),
            // Electronics = new Product("Electronics", 1m, ProductionType.consumerProduct, Invention.Electronics),
            // Gold = new Product("Gold", 4m, Color.yellow, ProductionType.industrial),
            // Education = new Product("Education", 4m, ProductionType.consumerProduct, false, Invention.Universities);


            public static readonly Product //Food, Sugar, Fibers, Fuel;
                Food = new Product("Food", 0.04m, new List<Product> {Fish, Grain, Cattle, Fruit}, ProductionType.consumerProduct),
                Sugar = new Product("Sugar", 0.04m, new List<Product> {Grain, Fruit}, ProductionType.consumerProduct),
                Fibers = new Product("Fibers", 0.04m, new List<Product> {Cattle, Cotton}, ProductionType.consumerProduct);
            //Fuel = new Product("Fuel", 0.04m, new List<Product> {Wood, Coal, Oil}, ProductionType.industrial);

        /// <summary>
        /// General constructor
        /// </summary>        
        private Product(string name, decimal defaultPrice, ProductionType productProductionType, params Invention[] requiredInventions) //: base(name)
        {
            //this.requiredInventions = requiredInventions;
           // this.defaultPrice = new Storage(Product.Gold, defaultPrice);
            allProducts.Add(this);
            switch (productProductionType)
            {
                case ProductionType.military:
                    _isMilitary = true;
                    break;

                case ProductionType.industrial:
                    _isIndustrial = true;
                    break;

                case ProductionType.consumerProduct:
                    _isConsumerProduct = true;
                    break;

                default:
                    throw new ArgumentException("Unknown product type " + productProductionType);
                    break;
            }
        }

        /// <summary>
        /// Constructor for resource product
        /// </summary>
        private Product(string name, decimal defaultPrice, Color color, ProductionType productProductionType, params Invention[] requiredInventions) : this(name, defaultPrice, productProductionType, requiredInventions)
        {
            this.color = color;
            _isResource = true;
            resourceCounter++;
        }

        /// <summary>
        /// Constructor for unstoreable product
        /// </summary>
        private Product(string name, decimal defaultPrice, ProductionType productProductionType, bool isStorable, params Invention[] requiredInventions) : this(name, defaultPrice, productProductionType, requiredInventions)
        {
            _isStoreable = false;
        }

        /// <summary>
        /// Constructor for abstract products
        /// </summary>
        private Product(string name, decimal defaultPrice, List<Product> substitutes, ProductionType productProductionType) : this(name, defaultPrice, productProductionType)
        {
            _isAbstract = true;
            this.substitutes = substitutes;
        }
    }

    internal class Invention
    {
    }
}