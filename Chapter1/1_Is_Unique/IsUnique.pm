#!/usr/bin/perl

use strict;
use warnings;

package IsUnique;

use Exporter qw(import);

our @EXPORT_OK = qw(is_unique);

# Runtime Complexity: O(1)
# Space Complexity: O(n) - n is number of characters of the input string
sub is_unique {
    my $input = shift;

    my %hash = ();
    my @chars = split '', $input;
    foreach my $char (@chars) {
        return 0 if exists $hash{$char};
        $hash{$char} = 1;
    }

    return 1;
}

1;
