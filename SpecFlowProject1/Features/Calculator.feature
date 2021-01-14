Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
	In order to avoid silly mistakes
	As a math idiot
	I *want* to be told the **sum** of ***two*** numbers

Link to a feature: [Calculator](SpecFlowProject1/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given the first number is <f1>
	And the second number is <f2>
	When the two numbers are added
	Then the result should be <sum>

	Examples:
	  | f1 | f2 | sum |
	  | 50 | 70 | 120 |
	  | 10 | 33 |  43 |