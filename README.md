# Labwork5
# Project README

## Overview
This is a simple console application written in C# that simulates a basic online store system. It includes classes for managing products, users, and orders, as well as an interface for searching products based on various criteria.

## Features
- **Product Management:** Create and manage products with details such as name, price, description, and category.
- **User Management:** Keep track of users with login credentials and purchase history.
- **Order Management:** Create and manage orders, including products, quantity, total price, and status.
- **Search Functionality:** Implement a search interface to find products based on criteria such as price, category, and rating.

## Classes and Interfaces
### ISearchable Interface
- Provides a generic search method for implementing search functionality.

### Product Class
- Represents a product with attributes like name, price, description, and category.

### User Class
- Represents a user with a username, password, and purchase history.

### Order Class
- Represents an order with products, quantity, total price, and status.

### Store Class
- Implements the ISearchable interface.
- Manages lists of products, users, and orders.
- Provides methods for managing users, products, and orders.

## Usage
1. Create an instance of the `Store` class.
2. Add products, users, and orders using the provided methods.
3. Utilize the search functionality to find products based on specified criteria.
4. Modify the code to incorporate data storage mechanisms like databases if needed.


Console.WriteLine("Search Results:");
foreach (var result in searchResults)
{
    Console.WriteLine($"{result.Name} - {result.Price:C} - {result.Category}");
}
