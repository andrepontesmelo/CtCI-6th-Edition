#!/usr/bin/perl

use strict;
use warnings;

use IsUnique qw(is_unique);

use Test::More tests => 5;

ok( is_unique(''),    'empty string' );
ok( is_unique('abc'), 'small non repeated string' );
ok( !is_unique('aa'), 'minimal not unique string' );

my $large_unique_string = join '', ( 'a' .. 'z', 'A' .. 'Z', '0' .. '9' );
ok( is_unique($large_unique_string),          'large unique string' );
ok( !is_unique( $large_unique_string . 'X' ), 'large not unique string' );
