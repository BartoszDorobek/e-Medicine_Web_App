//===============================================================================
//
// PlaZa System Platform
//
//===============================================================================
//
// Warsaw University of Technology
// Computer Networks and Services Division
// Copyright © 2020 PlaZa Creators
// All rights reserved.
//
//===============================================================================

namespace ZsutPw.Patterns.Application.Model
{
  using System;
  using System.Collections.Generic;
  using System.Diagnostics;
  using System.Linq;
  using System.Threading.Tasks;

  public class FakeNetworkClient : INetwork
  {
    private static readonly DoctorCabinet[ ] nodes = new DoctorCabinet[ ] 
    {
        new DoctorCabinet( ) { Name = "Jan Kowalski", Cabinet = "101a" }, 
        new DoctorCabinet( ) { Name = "Anna Kowalska", Cabinet = "300a" },
        new DoctorCabinet( ) { Name = "Jan Nowak", Cabinet = "102a" }, 
        new DoctorCabinet( ) { Name = "Gabriel Narutowicz", Cabinet = "300b" },
        new DoctorCabinet( ) { Name = "Anna Narutowicz", Cabinet = "101b" }, 
        new DoctorCabinet( ) { Name = "Marcelina Kowalska", Cabinet = "302" },
        new DoctorCabinet( ) { Name = "Barbara Nowak", Cabinet = "110a" }, 
        new DoctorCabinet( ) { Name = "Anna Świątek", Cabinet = "302b" }

    };

    public DoctorCabinet[ ] GetDoctorCabinet( string searchText )
    {
      return FakeNetworkClient.nodes.Where( dc => dc.Name.IndexOf( searchText ) >= 0 ).ToArray( );
    }
  }
}
