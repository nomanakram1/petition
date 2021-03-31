(function(window, undefined) {
  'use strict';

  /*
  NOTE:
  ------
  PLACE HERE YOUR OWN JAVASCRIPT CODE IF NEEDED
  WE WILL RELEASE FUTURE UPDATES SO IN ORDER TO NOT OVERWRITE YOUR JAVASCRIPT CODE PLEASE CONSIDER WRITING YOUR SCRIPT HERE.  */

    if (location.href.indexOf('home/admin') != -1) {        
        $("#homeIndex").addClass("active");
    }else
    if (location.href.indexOf('Batches/updateBatchesStatus') != -1) {
        $("#updateBatchesStatus").addClass("active");
        $("#updateBatchesStatus").parents(".has-sub").addClass("open");
    } else
    if (location.href.indexOf('home/petitions') != -1) {
        $("#homePetition").addClass("active");
        $("#homePetition").parents(".has-sub").addClass("open");
    }
    else
    if (location.href.indexOf('Batches/createBatches') != -1) {
        $("#createBatches").addClass("active");
        $("#createBatches").parents(".has-sub").addClass("open");
    }
    else
    if (location.href.indexOf('Batches/addDeleteCirculer') != -1) {
        $("#addDeleteCirculer").addClass("active");
        $("#addDeleteCirculer").parents(".has-sub").addClass("open");
    }
    else
    if (location.href.indexOf('Batches/editPurgeCount') != -1) {
        $("#editPurgeCount").addClass("active");
        $("#editPurgeCount").parents(".has-sub").addClass("open");
    }
    else
    if (location.href.indexOf('Batches/viewPrintBatches') != -1) {
        $("#viewPrintBatches").addClass("active");
        $("#viewPrintBatches").parents(".has-sub").addClass("open");
    }
    else
    if (location.href.indexOf('Batches/missingDataReceive') != -1) {
        $("#missingDataReceive").addClass("active");
        $("#missingDataReceive").parents(".has-sub").addClass("open");
    }
    else
    if (location.href.indexOf('home/userList') != -1) {
        $("#KPMUsers").addClass("active");
        $("#KPMUsers").parents(".has-sub").addClass("open");
    }
   

})(window);