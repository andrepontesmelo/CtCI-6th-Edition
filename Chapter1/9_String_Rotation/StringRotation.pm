#!/usr/bin/perl

use strict;
use warnings;

package StringRotation;

use Exporter qw(import);

our @EXPORT_OK = qw(string_rotation);

sub is_substring {
    my $whole = shift;
    my $part  = shift;

    return index( $whole, $part ) >= 0;
}

sub string_rotation {
    my $s1 = shift;
    my $s2 = shift;

    return 0 if length($s1) != length($s2);

    return is_substring( $s2 . $s2, $s1 );
}

1;
