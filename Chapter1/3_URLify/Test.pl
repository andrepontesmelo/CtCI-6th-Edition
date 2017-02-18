#!/usr/bin/perl

use strict;
use warnings;

use Urlify qw(urlify);

use Test::More tests => 3;

is(urlify(''), '', 'empty string' );
is(urlify(' '), '%20', 'one space string' );
is(urlify('i am a test'), 'i%20am%20a%20test', 'regular string' );
is(urlify('finishing with space '), 'finishing%20with%20space%20', 'string that finishes with space' );
