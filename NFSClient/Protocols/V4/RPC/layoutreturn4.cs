/*
 * Automatically generated by jrpcgen 1.0.7 on 29.11.2012
 * jrpcgen is part of the "Remote Tea.Net" ONC/RPC package for C#
 * See http://remotetea.sourceforge.net for details
 */
namespace NFSLibrary.Protocols.V4.RPC{
using org.acplt.oncrpc;

public class layoutreturn4 : XdrAble {
    public int lr_returntype;
    public layoutreturn_file4 lr_layout;

    public layoutreturn4() {
    }

    public layoutreturn4(XdrDecodingStream xdr) {
        xdrDecode(xdr);
    }

    public void xdrEncode(XdrEncodingStream xdr) {
        xdr.xdrEncodeInt(lr_returntype);
        switch ( lr_returntype ) {
        case layoutreturn_type4.LAYOUTRETURN4_FILE:
            lr_layout.xdrEncode(xdr);
            break;
        default:
            break;
        }
    }

    public void xdrDecode(XdrDecodingStream xdr) {
        lr_returntype = xdr.xdrDecodeInt();
        switch ( lr_returntype ) {
        case layoutreturn_type4.LAYOUTRETURN4_FILE:
            lr_layout = new layoutreturn_file4(xdr);
            break;
        default:
            break;
        }
    }

}
} // End of layoutreturn4.cs