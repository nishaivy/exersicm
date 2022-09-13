# Alphametics

Welcome to Alphametics on Exercism's C# Track.
If you need help running the tests or submitting your code, check out `HELP.md`.

## Instructions

Write a function to solve alphametics puzzles.

[Alphametics](https://en.wikipedia.org/wiki/Alphametics) is a puzzle where
letters in words are replaced with numbers.

For example `SEND + MORE = MONEY`:

```text
  S E N D
  M O R E +
-----------
M O N E Y
```

Replacing these with valid numbers gives:

```text
  9 5 6 7
  1 0 8 5 +
-----------
1 0 6 5 2
```

This is correct because every letter is replaced by a different number and the
words, translated into numbers, then make a valid sum.

Each letter must represent a different digit, and the leading digit of
a multi-digit number must not be zero.

Write a function to solve alphametics puzzles.

- To parse the text, you could try to use the [Sprache](https://github.com/sprache/Sprache/blob/develop/README.md) library. You can also find a good tutorial [here](https://www.thomaslevesque.com/2017/02/23/easy-text-parsing-in-c-with-sprache/).
- You can solve this exercise with a brute force algorithm, but this will possibly have a poor runtime performance.
  Try to find a more sophisticated solution.
- Hint: You could try the column-wise addition algorithm that is usually taught in school.

## Source

### Created by

- @ErikSchierboom

### Contributed to by

- @j2jensen
- @robkeim
- @wolf99

# Flatten Array

Welcome to Flatten Array on Exercism's C# Track.
If you need help running the tests or submitting your code, check out `HELP.md`.

## Instructions

Take a nested list and return a single flattened list with all values except nil/null.

The challenge is to write a function that accepts an arbitrarily-deep nested list-like structure and returns a flattened structure without any nil/null values.

For Example

input: [1,[2,3,null,4],[null],5]

output: [1,2,3,4,5]

## Source

### Created by

- @ErikSchierboom

### Contributed to by

- @felix91gr
- @j2jensen
- @robkeim
- @wolf99

### Based on

Interview Question - https://reference.wolfram.com/language/ref/Flatten.html

# Palindrome Products

Welcome to Palindrome Products on Exercism's C# Track.
If you need help running the tests or submitting your code, check out `HELP.md`.

## Instructions

Detect palindrome products in a given range.

A palindromic number is a number that remains the same when its digits are
reversed. For example, `121` is a palindromic number but `112` is not.

Given a range of numbers, find the largest and smallest palindromes which
are products of two numbers within that range.

Your solution should return the largest and smallest palindromes, along with the
factors of each within the range. If the largest or smallest palindrome has more
than one pair of factors within the range, then return all the pairs.

## Example 1

Given the range `[1, 9]` (both inclusive)...

And given the list of all possible products within this range:
`[1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14, 16, 18, 15, 21, 24, 27, 20, 28, 32, 36, 25, 30, 35, 40, 45, 42, 48, 54, 49, 56, 63, 64, 72, 81]`

The palindrome products are all single digit numbers (in this case):
`[1, 2, 3, 4, 5, 6, 7, 8, 9]`

The smallest palindrome product is `1`. Its factors are `(1, 1)`.
The largest palindrome product is `9`. Its factors are `(1, 9)` and `(3, 3)`.

## Example 2

Given the range `[10, 99]` (both inclusive)...

The smallest palindrome product is `121`. Its factors are `(11, 11)`.
The largest palindrome product is `9009`. Its factors are `(91, 99)`.

For this exercise, you will need to create a set of factors using tuples.
For more information on tuples, see [this link](https://docs.microsoft.com/en-us/dotnet/api/system.tuple?view=net-6.0).

## Source

### Created by

- @ErikSchierboom

### Contributed to by

- @bressain
- @j2jensen
- @jmbradnan
- @robkeim
- @wolf99

### Based on

Problem 4 at Project Euler - http://projecteuler.net/problem=4

# Phone Number

Welcome to Phone Number on Exercism's C# Track.
If you need help running the tests or submitting your code, check out `HELP.md`.

## Instructions

Clean up user-entered phone numbers so that they can be sent SMS messages.

The **North American Numbering Plan (NANP)** is a telephone numbering system used by many countries in North America like the United States, Canada or Bermuda. All NANP-countries share the same international country code: `1`.

NANP numbers are ten-digit numbers consisting of a three-digit Numbering Plan Area code, commonly known as *area code*, followed by a seven-digit local number. The first three digits of the local number represent the *exchange code*, followed by the unique four-digit number which is the *subscriber number*.

The format is usually represented as

```text
(NXX)-NXX-XXXX
```

where `N` is any digit from 2 through 9 and `X` is any digit from 0 through 9.

Your task is to clean up differently formatted telephone numbers by removing punctuation and the country code (1) if present.

For example, the inputs

- `+1 (613)-995-0253`
- `613-995-0253`
- `1 613 995 0253`
- `613.995.0253`

should all produce the output

`6139950253`

**Note:** As this exercise only deals with telephone numbers used in NANP-countries, only 1 is considered a valid country code.

## Source

### Created by

- @bressain

### Contributed to by

- @ErikSchierboom
- @j2jensen
- @jwood803
- @kytrinyx
- @robkeim
- @tomschluter
- @vgrigoriu
- @wolf99

### Based on

Event Manager by JumpstartLab - http://tutorials.jumpstartlab.com/projects/eventmanager.html
