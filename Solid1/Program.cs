using System;
using System.Collections.Generic;

// Клас Order раніше виконував кілька різних задач: управління замовленням, його показ і збереження.
// Щоб усунути це, обов'язки розділено між окремими класами.

namespace Solid1
{
    class Item { }

    // Клас для управління замовленням
    class Order
    {
        private List<Item> itemList;

        public Order()
        {
            itemList = new List<Item>();
        }

        public List<Item> ItemList => itemList;

        public void CalculateTotalSum() { /*...*/ }
        public void GetItems() { /*...*/ }
        public void GetItemCount() { /*...*/ }
        public void AddItem(Item item) { /*...*/ }
        public void DeleteItem(Item item) { /*...*/ }
    }

    // Клас для показу замовлення
    class OrderViewer
    {
        public void PrintOrder(Order order) { /*...*/ }
        public void ShowOrder(Order order) { /*...*/ }
    }

    // Клас для операцій збереження та завантаження замовлень
    class OrderRepository
    {
        public void Load(Order order) { /*...*/ }
        public void Save(Order order) { /*...*/ }
        public void Update(Order order) { /*...*/ }
        public void Delete(Order order) { /*...*/ }
    }

    class Program
    {
        static void Main() { }
    }
}
