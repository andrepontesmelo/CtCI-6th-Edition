#!/usr/bin/perl

use strict;
use warnings;

package PalindromePermutation;

use Exporter qw(import);

our @EXPORT_OK = qw(palindrome_permutation);

sub palindrome_permutation {
    my $input = shift;

    my @occurrences = (0) x 256;
    foreach my $idx ( 0 .. length($input) - 1 ) {
        $occurrences[ ord( substr( $input, $idx, 1 ) ) ]++;
    }

    my $odd_count_characters = 0;
    foreach my $char_count (@occurrences) {
        my $is_odd = $char_count % 2 == 1;

        if ($is_odd) {
            $odd_count_characters++;

            return 0 if $odd_count_characters > 1;
        }
    }

    return 1;
}

1;
