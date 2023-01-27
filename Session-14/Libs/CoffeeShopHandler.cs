using Session_11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Libs {
    public class CoffeeShopHandler {
        public bool errorAtLoad = false;

        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<Product> Products { get; set; } = new List<Product>();
        public List<ProductCategory> ProductCategories {get; set;} = new List<ProductCategory>();
        public List<Transaction> Transactions { get; set; }=new List<Transaction>();

        //init employees
        public void CheckAndPopulateEmployees()
        {
            if (Employees.Count == 0)
            {
                if (File.Exists("employee.json"))
                {
                    DeserializeEmployee();
                    CheckLimits();  // changed to bool from void cause i need it inside forms to check if adds are good. Still works like a charm
                }
                else
                {
                    SetDefaultEmployees(); 
                }
            }
        }

        //init productCategories
        public void CheckAndPopulateProductCategories() {
            string fileName = "product-category.json";
            if (File.Exists(fileName)) {
                try {
                    DeserializeProductCategory();
                }
                catch (Exception ex) {
                    //log exception
                    SetDefaultProductCategories();
                }
            }
            else {
                SetDefaultProductCategories();
            }
        }


        //init products
        public void CheckAndPopulateProducts() {
            errorAtLoad = false;
            string fileName = "product.json";
            if (File.Exists(fileName)) {
                try {
                    DeserializeProduct();
                    //ConnectProductCategoryIDs();
                    
                }
                catch (Exception ex) {
                    //log exception
                    SetDefaultProducts();
                    errorAtLoad = true;

                }
            }
            else {
                SetDefaultProducts();
                errorAtLoad = true;
            }
        }

        public bool CheckLimitsForm() {
            bool ok = true;
            int managers = 0;
            int cashiers = 0;
            int baristas = 0;
            int waiters = 0;

            foreach (var employee in Employees) {
                switch (employee.EmployeeType) {
                    case EmployeeType.Manager:
                        managers++;
                        break;
                    case EmployeeType.Cashier:
                        cashiers++;
                        break;
                    case EmployeeType.Barista:
                        baristas++;
                        break;
                    case EmployeeType.Waiter:
                        waiters++;
                        break;
                }
            }
            if (managers != 1) {
                ok = false; 
            }
            if (cashiers < 1 || cashiers > 2) {
                ok = false;
            }
            if (baristas < 1 || baristas > 2) {
                ok = false;
            }
            if (waiters < 1 || waiters > 2) {
                ok = false;
            }
            return ok;
        }
        public void  CheckLimits() {

            int managers = 0;
            int cashiers = 0;
            int baristas = 0;
            int waiters = 0;

            foreach (var employee in Employees) {
                switch (employee.EmployeeType) {
                    case EmployeeType.Manager:
                        managers++;
                        break;
                    case EmployeeType.Cashier:
                        cashiers++;
                        break;
                    case EmployeeType.Barista:
                        baristas++;
                        break;
                    case EmployeeType.Waiter:
                        waiters++;
                        break;
                }
            }
            if (managers < 1 || managers > 1) {
                
                SetDefaultEmployees();
                errorAtLoad = true;

            }
            if (cashiers < 1 || cashiers > 2) {
                
                SetDefaultEmployees();
                errorAtLoad = true;
            }
            if (baristas < 1 || baristas > 2) {
                
                SetDefaultEmployees();
                errorAtLoad = true;
            }
            if (waiters < 1 || waiters > 2) {
                
                SetDefaultEmployees();
                errorAtLoad = true;
            }
            
        }

        public void SetDefaultEmployees() {
            Employees.Add(new Employee { Name = "Stratos ", Surname = "Chalkopiadis", Salary = 4000, EmployeeType = EmployeeType.Manager });
            Employees.Add(new Employee { Name = "Giorgos", Surname = " Zacharidis", Salary = 3000, EmployeeType = EmployeeType.Cashier });
            Employees.Add(new Employee { Name = "Anestis", Surname = " Kountoyrgiannis", Salary = 2000, EmployeeType = EmployeeType.Barista });
            Employees.Add(new Employee { Name = "Ioannis", Surname = " Koukotzilas", Salary = 1000, EmployeeType = EmployeeType.Waiter });
        }
        public void SetDefaultProducts() {
            Products.Add(new Product { Code = "123", Description = "Espresso", Price = 1.9m, Cost = 1.5m });
            Products.Add(new Product { Code = "456", Description = "Cola", Price = 1.5m, Cost = 0.5m });
            Products.Add(new Product { Code = "789", Description = "Toast", Price = 1.1m, Cost = 0.5m });
        }
        public void SetDefaultProductCategories() {
            ProductCategories.Add(new ProductCategory { Code = "Product category 1 code", Description = "Coffee", ProductType = ProductType.Coffee });
            ProductCategories.Add(new ProductCategory { Code = "Product category 2 code", Description = "Beverage", ProductType = ProductType.Beverages });
            ProductCategories.Add(new ProductCategory { Code = "Product category 3 code", Description = "Food", ProductType = ProductType.Food });
            
        }
        public void SerializeEmployee() {
            Serializer serializer = new Serializer();
            serializer.SerializeToFile(Employees, "employee.json");
        }

        public void DeserializeEmployee() {
            Serializer serializer = new Serializer();
            if (File.Exists("employee.json")) { 
            Employees = serializer.DeserializeFromFile<List<Employee>>("employee.json");
        }
        }

        public void SerializeProduct() {
            Serializer serializer = new Serializer();
            serializer.SerializeToFile(Products, "product.json");
        }

        public void DeserializeProduct() {
            if (File.Exists("product.json")) {
                Serializer serializer = new Serializer();
                Products = serializer.DeserializeFromFile<List<Product>>("product.json");
            }
        }

        public void SerializeProductCategory() {
            Serializer serializer = new Serializer();
            serializer.SerializeToFile(ProductCategories, "product-category.json");
        }

        public void DeserializeProductCategory() {
            if (File.Exists("product-category.json")) {
                Serializer serializer = new Serializer();
                ProductCategories = serializer.DeserializeFromFile<List<ProductCategory>>("product-category.json");
            }
        }

        public void Init() {
            CheckAndPopulateEmployees();
            CheckAndPopulateProductCategories();
            CheckAndPopulateProducts();
        }
        public void Save() {
            SerializeEmployee();
            SerializeProductCategory();
            SerializeProduct();
        }

        //Apo edw kai katw exei mono arrwstia kai paranoia
        public ProductCategory GetCategoryById(Guid categoryId) {
            foreach (Product product in Products) {
                if (product.ProductCategoryID == categoryId) {
                    return ProductCategories.Find(x => x.ProductCategoryID == categoryId);
                }
            }
            return null;
        }
        public List<ProductType> GetProductTypes() {
            var productTypes = new List<ProductType>();
            foreach (var product in Products) {
                productTypes.Add(GetProductCategoryById(product.ProductCategoryID).ProductType);
            }
            return productTypes;
        }
        public ProductCategory GetProductCategoryById(Guid id) {
            return ProductCategories.FirstOrDefault(x => x.ProductCategoryID == id);
        }

    }

}


