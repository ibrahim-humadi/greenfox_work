#!/bin/bash

echo -e "hello sir, please enter you name"
read name
echo -e "welcome $name, Please type in your age"
read age
echo -e "are you a dog or cat person?"
read pet

if [ $pet = "dog" ]; then
let "dogage = $age * 7"
echo "How lovely, did you know you are $dogage years old in dog years?"
elif [ $pet = "cat" ]; then
let "catage = $age * 4"
echo "Very cool, did you know you are $catage years old in cat years?"
fi

echo -e "what would you like to search?"
read site

cd \Users\tiglath\Desktop\myFirstWebsite
