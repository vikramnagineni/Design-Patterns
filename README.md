# Design-Patterns
I have explained each design pattern starting from day1(from no design pattern) to dayn(full usage of design pattern).
- Day1 - I start implementing requirements given by customer without using design pattern and i will explain what are the problems I face.
- Day2 - Improve the code using design pattern(or) implement the new requirement from customer
- Day3 - ..........
- Dayn - By last day, You will understand why, when and how to use the design pattern

## Difference b/w Factory Method and Abstract factory.
### 1.Factory Method:
A factory that creates objects that derive from a particular base class.
### Abstract factory:
A factory that creates other factories, and these factories in turn create objects derived from base classes. You do this because you often don't just want to create a single object (as with Factory method) - rather, you want to create a collection of related objects.

### 2.Factory Method:
Imagine you are constructing a house and you approach a carpenter for a door. You give the measurement for the door and your requirements, and he will construct a door for you. In this case, the carpenter is a factory of doors. Your specifications are inputs for the factory, and the door is the output or product from the factory.
### Abstract Factory:
Now, consider the same example of the door. You can go to a carpenter, or you can go to a plastic door shop or a PVC shop. All of them are door factories. Based on the situation, you decide what kind of factory you need to approach. This is like an Abstract Factory.
