Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be able to convert to different number formats

@mytag
Scenario: convert hexa
	Given the input is <affe>
	When the input is converted from 16
	Then the result should be 45054

@mytag
Scenario: convert octa
	Given the input is <11147>
	When the input is converted from 8
	Then the result should be 4711

@mytag
Scenario: convert biny
	Given the input is <1100>
	When the input is converted from 2
	Then the result should be 12
