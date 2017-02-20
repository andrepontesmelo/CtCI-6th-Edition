#!/usr/bin/perl

use strict;
use warnings;

package StringCompressionConcat;

use Exporter qw(import);
use ChunkCompression qw(compress_chunk);

our @EXPORT_OK = qw(string_compression);

sub string_compression {
    my $input      = shift;
    my $compressed = '';
    my $last_char  = '';
    my $char_count = 0;

    foreach my $idx ( 0 .. length($input) - 1 ) {
        my $current_char = substr( $input, $idx, 1 );
        my $changed_char = $current_char ne $last_char;
        if ( $changed_char && ( $last_char ne '' ) ) {
            $compressed .= compress_chunk( $last_char, $char_count );
            $char_count = 0;
        }

        $last_char = $current_char;
        $char_count++;
    }

    $compressed .= compress_chunk( $last_char, $char_count );

    return length($compressed) < length($input) ? $compressed : $input;
}

1;
