#!/usr/bin/perl

use strict;
use warnings;

package ChunkCompression;

use Exporter qw(import);

our @EXPORT_OK = qw(compress_chunk);

sub compress_chunk {
    my $char  = shift;
    my $count = shift;

    return $char . $count;
}

1;
