#!/usr/bin/perl

use strict;
use warnings;

package CheckPermutation;

use Exporter qw(import);

our @EXPORT_OK = qw(check_permutation);

sub sum_count_array {
    my $count  = shift;
    my $string = shift;
    my $qty    = shift;

    foreach my $i ( 0 .. length($string) ) {
        $count->[ ord( substr( $string, $i, 1 ) ) ] += $qty;
    }
}

# Runtime Complexity: O(n) - n is length of string.
# Space Complexity: O(1).
sub check_permutation {
    my $a = shift;
    my $b = shift;

    return 0 if length($a) != length($b);

    my @count = (0) x 255;

    sum_count_array( \@count, $a, 1 );
    sum_count_array( \@count, $b, -1 );

    foreach my $x (@count) {
        return 0 if $x != 0;
    }

    return 1;
}

1;
