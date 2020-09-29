# SOLID PRICIPLE

## Introduction
The motivation of the project is to summarize the SOLID priciple and shows how it is affected of not implementing this design.

## Software Desgin Pattern 
It is the best pratice to solve software problems

## Definition
- **S** - Single Responsible Principle: the class should solve only one problem and it should have a signle reason to change.
    - Other explanation would be:
        - "Do one thing and do it well".
        - Uncle Bob says "There should never be more than one reason for a class to change".
        - A class should have one and only one reason to change, meaning a class should have only one job.
- **O** - Open / Closed Principle: the class should be open for extension and closed for modification.
    - Other explanation would be:
        - "The open/closed principle states that software entitles (classes, modules, functions, etc.) should be open for extension, but closed for modifications." 
        - Any new functionality should be done by adding new classes instead of changing existing one.
- **L** - Liskov Substitution Principle: if you substutite any type with one of its subtypes, the behavior should not change.
    - Other explanation would be:
        - "If you have class **B** inherits from class **A**, then class **A** should be replaceable by class **B** without any change"
- **I** - Interface Segregation Principle: avoid making general interface contains all methods.
    - Other explanation would be:
        - "Client should not be forced to depend on methods they do not use"
        - Avoid fat interface
        - Client must not implement unnecessary methods
- **D** - Depenency Inversion Principle: higher level classes should not know the implementation of low level classes but depend on abstraction.