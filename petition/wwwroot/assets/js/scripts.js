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
    else
        if (location.href.indexOf('ManagerUsers/AssignCoordinators') != -1) {
            $("#assignCoordinators").addClass("active");
            $("#assignCoordinators").parents(".has-sub").addClass("open");
                                        }
    else
        if (location.href.indexOf('home/petitions') != -1) {
            $("#assignSubCoordinators").addClass("active");
            $("#assignSubCoordinators").parents(".has-sub").addClass("open");
                                            }
    else
            if (location.href.indexOf('ManagerUsers/AssignSubCoordinators') != -1) {
            $("#assignSubCoordinators").addClass("active");
            $("#assignSubCoordinators").parents(".has-sub").addClass("open");
                                                }
    else
            if (location.href.indexOf('ManagerUsers/ManageCirculator') != -1) {
            $("#manageCirculator").addClass("active");
            $("#manageCirculator").parents(".has-sub").addClass("open");
        }
    else
            if (location.href.indexOf('ManagerUsers/AssignExternalValidators') != -1) {
            $("#assignExternalValidators").addClass("active");
            $("#assignExternalValidators").parents(".has-sub").addClass("open");
                                                        }
    else
                if (location.href.indexOf('ManagerUsers/ManageInternalValidators') != -1) {
            $("#manageInternalValidators").addClass("active");
            $("#manageInternalValidators").parents(".has-sub").addClass("open");
                                                            }
    else
            if (location.href.indexOf('Reports/NewBatchSubmission') != -1) {
            $("#newBatchSubmission").addClass("active");
            $("#newBatchSubmission").parents(".has-sub").addClass("open");
                                                                }
    else
            if (location.href.indexOf('Reports/PetitionStatistics') != -1) {
            $("#PetitionStatistics").addClass("active");
            $("#PetitionStatistics").parents(".has-sub").addClass("open");
                                                                    }
    else
            if (location.href.indexOf('Reports/CountyAnalysis') != -1) {
            $("#countyAnalysis").addClass("active");
            $("#countyAnalysis").parents(".has-sub").addClass("open");
                                                                        }
    else
            if (location.href.indexOf('Reports/CoordinatorBatchReport') != -1) {
            $("#coordinatorBatchReport").addClass("active");
            $("#coordinatorBatchReport").parents(".has-sub").addClass("open");
                                                                            }
    else
            if (location.href.indexOf('Reports/CountyAnalysis') != -1) {
            $("#countyAnalysis").addClass("active");
            $("#countyAnalysis").parents(".has-sub").addClass("open");
                                                                                }
    else
            if (location.href.indexOf('Reports/CoordinatorBatchReport') != -1) {
            $("#coordinatorBatchReport").addClass("active");
            $("#coordinatorBatchReport").parents(".has-sub").addClass("open");
        }
})(window);