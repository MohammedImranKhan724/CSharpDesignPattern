# 🚀 CSharpDesignPattern

A comprehensive repository for learning **Low Level Design (LLD)** using **Design Patterns in C#**.

This project focuses on understanding, implementing, and practicing design patterns as they are used in **real-world, industry-level applications**, not just theory.

---

## 📌 Purpose of This Repository

- Learn **Low Level Design (LLD)** concepts in C#
- Understand **why** and **when** to use each design pattern
- Implement patterns using **clean, readable, and industry-standard C# code**
- Prepare for **interviews**, **system design rounds**, and **real projects**

---

## 🧠 What is Low Level Design (LLD)?

Low Level Design focuses on:
- Class design
- Object relationships
- SOLID principles
- Design patterns
- Maintainable and extensible code

Design patterns solve **recurring design problems** in a structured and reusable way.

---

## 🧩 Design Pattern Categories

### 🏗️ Creational Patterns
Creational patterns deal with **object creation mechanisms**, improving flexibility and reuse.

- Builder  
- Factory Method  
- Abstract Factory  
- Singleton  
- Prototype  

---

### 🔗 Structural Patterns
Structural patterns focus on **class and object composition**.

- Adapter  
- Decorator  
- Facade  
- Composite  
- Proxy  
- Bridge  
- Flyweight  

---

### 🔄 Behavioral Patterns
Behavioral patterns focus on **communication and responsibility between objects**.

- Strategy  
- Observer  
- Command  
- Chain of Responsibility  
- State  
- Template Method  
- Iterator  
- Mediator  
- Memento  
- Visitor  

---

## 🛠️ What Each Pattern Includes

Each design pattern implementation contains:

- 📄 Problem statement
- 🧱 Pattern structure
- 💡 Real-world use case
- ✅ Clean C# implementation
- 🧪 Example usage
- 📝 Notes & best practices

---

## 🧪 Example (Builder Pattern)

Two **industry-standard** Builder patterns are implemented:

1. **Fluent Builder** – used for configuration and DTOs  
2. **Immutable Object Builder (Inner Builder)** – used for domain models  

```csharp
var order = new Order.Builder("ORD-101", 1500)
    .MarkAsPaid()
    .AddNotes("Priority order")
    .Build();
