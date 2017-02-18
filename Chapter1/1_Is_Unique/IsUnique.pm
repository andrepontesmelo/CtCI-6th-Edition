#!/usr/bin/perl

use strict;
use warnings;

package IsUnique;

use Exporter qw(import);

our @EXPORT_OK = qw(is_unique);

# Runtime Complexity: O(1) for string length > 255, O(n) otherwise.
# Space Complexity: O(1) - Additional array of bits with fixed size.
sub is_unique {
    my $input = shift;

    return 0 if ( length($input) > 255 );

    my @bitArray = (0) x 255;
    foreach my $idx ( 0 .. length($input) ) {
        my $ord = ord( substr( $input, $idx, 1 ) );
        return 0 if $bitArray[$ord];
        $bitArray[$ord] = 1;
    }

    return 1;
}

1;
