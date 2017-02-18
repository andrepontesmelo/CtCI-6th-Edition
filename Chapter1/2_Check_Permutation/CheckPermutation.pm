#!/usr/bin/perl

use strict;
use warnings;

package CheckPermutation;

use Exporter qw(import);

our @EXPORT_OK = qw(check_permutation);

# Runtime Complexity:
# Space Complexity:
sub check_permutation {
    my $a = shift;
    my $b = shift;

    return 0 if length($a) != length($b);

    my @count = (0) x 255;
    foreach my $i ( 0 .. length($a) ) {
        $count[ ord( substr( $a, $i, 1 ) ) ]++;
    }

    foreach my $i ( 0 .. length($b) ) {
        $count[ ord( substr( $b, $i, 1 ) ) ]--;
    }

    foreach my $x (@count) {
        return 0 if $x != 0;
    }

    return 1;
}

1;
