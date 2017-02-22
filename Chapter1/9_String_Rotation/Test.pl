#!/usr/bin/perl

use strict;
use warnings;

use StringRotation qw(string_rotation);

use Test::More tests => 3;

ok( string_rotation( '', '' ), 'empty string' );

ok( string_rotation( 'waterbottle', 'erbottlewat' ),
    ' string rotation of waterbottle' );

ok( !string_rotation( 'waterbottle', 'erbottleXat' ),
    ' not a string rotation' );
