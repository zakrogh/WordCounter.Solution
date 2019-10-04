# _Word Counter_

#### _A program created to practice unit testing in C# 10/4/2019_

#### By _Zach Krogh_

## Description

_This console application accepts two inputs from the user, a sentence, and a word. It then searches the sentence for all instances of the word. It will only match the full word by itself, not partial strings of other words.  (For instance, if provided the word "cat" and sentence "I'm walking to the cathedral." the first three letters of the word cathedral would not be counted.)_

## Setup/Installation Requirements

* _Install dotnet core._
* _Download all files into the same directory and run "dotnet run"_

## Project Specifications

* _The user can input a word and a sentence._
  * _input: word:"word" sentence:"this is a sentence"_
  * _output: none (the word and sentence are saved to variables)_
  * _description: This is the most basic requirement of the program, so the input is just two strings._
* _The program will find a word in a 1 word sentence._
  * _input: word: "word" sentence:"word"_
  * _output: word count: 1_
  * _description: A one word sentence is the simplest scenario for the finished program to solve._
* _The program will find all instances of a word in a sentence._
  * _input: word: "word" sentence:"word sentence word containing three word"._
  * _output: word count: 3_
  * _description: A sentence with multiple instances of the word is the most complex behavior of the program_
* _The program will not count partial word matches_
  * _input: word: "word" sentence:"words"_
  * _output: word count: 0_
  * _description: Partial word matches are not counted._

## Support and contact details

_contact: zakrogh@gmail.com_

## Technologies Used

_C#_

### License

*MIT License*

Copyright (c) 2019 **_Zach Krogh_**
