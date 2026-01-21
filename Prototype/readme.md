# 🧬 Prototype Design Pattern (C#)

## 📌 What is Prototype Design Pattern?

The **Prototype Design Pattern** is a **creational design pattern** that creates new objects by **copying an existing object**, instead of creating a new one using `new`.

In simple words:

> **Create object by copying another object**

---

## ❓ Why Prototype Pattern is Needed?

Sometimes creating an object is:
- Time-consuming
- Complex
- Repetitive

If many objects are **similar**, it is better to **copy** an existing object instead of creating it again and again.

---

## 🧠 Real-Life Example (Very Simple)

🧾 **Office Document Template**

- You create a document template once
- Then you make copies of it
- Each copy can be modified separately

---

## 🧱 Basic Structure

1. Prototype Interface → defines `Clone()`
2. Concrete Class → implements cloning
3. Client → uses `Clone()`

---

## 🔹 Prototype Interface

```csharp
public interface IPrototype<T>
{
    T Clone();
}