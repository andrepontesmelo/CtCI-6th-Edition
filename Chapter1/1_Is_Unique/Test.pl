#!/usr/bin/perl

use strict;
use warnings;

use IsUnique qw(is_unique);

use Test::More tests => 4;

ok( is_unique(''),    'empty string' );
ok( is_unique('abc'), 'small non repeated string' );
ok( !is_unique('aa'), 'minimal not unique string' );
ok( is_unique( join '', ( 'a' .. 'z', 'A' .. 'Z', '0' .. '9' ) ),
    'large unique string' );
