#!/usr/bin/perl

use strict;
use warnings;

use PalindromePermutation qw(palindrome_permutation);

use Test::More tests => 9;

ok( palindrome_permutation(''),      'empty string' );
ok( palindrome_permutation('a'),     'one character string' );
ok( !palindrome_permutation('ab'),   'small non palindrome' );
ok( palindrome_permutation('aba'),   'small palindrome' );
ok( palindrome_permutation('aabaa'), 'palindrome with a x 2 each side' );
ok( palindrome_permutation('aabbcc'),
    'palindrome permutation - only even counts' );
ok(
    palindrome_permutation('aabbccw'),
    'palindrome permutation - one odd count'
);
ok(
    !palindrome_permutation('aabbccws'),
    'not palindrome permutation - two odd count'
);
ok(
    !palindrome_permutation('aabbccwsz'),
    'not palindrome permutation - three odd count'
);
