#!/usr/bin/perl

use strict;
use warnings;

use StringCompressionList qw(string_compression);

use Test::More tests => 3;

is( string_compression('aabcccccaaa'), 'a2b1c5a3', 'compress' );
is( string_compression('abc'), 'abc', 'do not compress - would be bigger ' );
is( string_compression('aabc'), 'aabc',
    'do not compress - would be same size' );
